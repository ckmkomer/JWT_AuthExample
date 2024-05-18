using AutoMapper.Internal.Mappers;
using JWT_Auth_Example.Core.Repositories;
using JWT_Auth_Example.Core.Services;
using JWT_Auth_Example.Core.UnitOfWork;
using JWT_Auth_Example.Service.Mapper;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Dtos;
using System.Linq.Expressions;

namespace JWT_Auth_Example.Service.Services
{
	public class Service<TEntity, TDto> : IService<TEntity, TDto> where TEntity : class where TDto : class

	{
		private readonly IUnitOfWork _unitOfWork;

		private readonly IGenericRepository<TEntity> _genericRepository;

		public Service(IUnitOfWork unitOfWork, IGenericRepository<TEntity> genericRepository)
		{
			_unitOfWork = unitOfWork;
			_genericRepository = genericRepository;
		}

		public async Task<Response<TDto>> AddAsync(TDto entity)
		{
			var newEntity = ObjectMapper.Mapper.Map<TEntity>(entity);

			await _genericRepository.CreateAsync(newEntity);

			await _unitOfWork.CommitAsync();

			var newDto = ObjectMapper.Mapper.Map<TDto>(newEntity);

			return Response<TDto>.Success(newDto, 200);
		}

		public async Task<Response<IEnumerable<TDto>>> GetAllAsync()
		{
			var products = ObjectMapper.Mapper.Map<List<TDto>>(await _genericRepository.GetAllAsync());

			return Response<IEnumerable<TDto>>.Success(products, 200);
		}

		public async Task<Response<TDto>> GetByIdAsync(int id)
		{
			var product = await _genericRepository.GetByIdAsync(id);

			if (product == null)
			{
				return Response<TDto>.Fail("Id not found", 404, true);
			}

			return Response<TDto>.Success(ObjectMapper.Mapper.Map<TDto>(product), 200);
		}

		public async Task<Response<NoDataDto>> Remove(int id)
		{
			var isExistEntity = await _genericRepository.GetByIdAsync(id);

			if (isExistEntity == null)
			{
				return Response<NoDataDto>.Fail("Id not found", 404, true);
			}

			_genericRepository.Delete(isExistEntity);

			await _unitOfWork.CommitAsync();
			//204 durum kodu =>  No Content  => Response body'sinde hiç bir dat  olmayacak.
			return Response<NoDataDto>.Success(204);
		}

		public async Task<Response<NoDataDto>> Update(TDto entity, int id)
		{
			var isExistEntity = await _genericRepository.GetByIdAsync(id);

			if (isExistEntity == null)
			{
				return Response<NoDataDto>.Fail("Id not found", 404, true);
			}

			var updateEntity = ObjectMapper.Mapper.Map<TEntity>(entity);

			_genericRepository.Update(updateEntity);

			await _unitOfWork.CommitAsync();
			//204 durum kodu =>  No Content  => Response body'sinde hiç bir data  olmayacak.
			return Response<NoDataDto>.Success(204);
		}

		public async Task<Response<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate)
		{
			// where(x=>x.id>5)
			var list = _genericRepository.Where(predicate);

			return Response<IEnumerable<TDto>>.Success(ObjectMapper.Mapper.Map<IEnumerable<TDto>>(await list.ToListAsync()), 200);
		}
	
}
}
