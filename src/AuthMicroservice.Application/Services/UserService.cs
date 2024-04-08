using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using AuthMicroservice.Application.DTOs;
using AuthMicroservice.Domain.Entities;
using AuthMicroservice.Domain.Interfaces.DTOs;
using AuthMicroservice.Domain.Interfaces.Entities;
using AuthMicroservice.Domain.Interfaces.Repositories;
using AuthMicroservice.Domain.Interfaces.Services;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Grpc.Core;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.CodeAnalysis.Host;

namespace AuthMicroservice.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IQueryable<IUserListDTO> GetAll()
        {
            IQueryable<IUser> users = _repository.GetAll();

            IQueryable<IUserListDTO> usersListDTO = users.ProjectTo<UserListDTO>(_mapper.ConfigurationProvider);

            return usersListDTO;
        }

        public async Task<IUserDetailDTO> GetDetail(Guid id)
        {
            IUser user = await _repository.GetDetail(id);
            return _mapper.Map<UserDetailDTO>(user);
        }

        public async Task<IUserListDTO> GetById(Guid id)
        {
            var user = await _repository.GetDetail(id);
            return _mapper.Map<UserListDTO>(user);
        }

        public async Task<IUserListDTO> Create(IUserCreateDTO userDto)
        {
            User newUser = _mapper.Map<User>(userDto);

            await _repository.Create(newUser);
            IUser createdUser = await _repository.GetDetail(newUser.Id);

            return _mapper.Map<UserListDTO>(createdUser);
        }

        public async Task<IUserListDTO> Update(Guid id, IUserUpdateDTO userUpdateDTO)
        {
            IUser user = await _repository.GetDetail(id);

            if (user == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "User not found"));
            }

            _mapper.Map(userUpdateDTO, user);

            bool updated = await _repository.Update(id, user); 

            if (!updated)
            {
                throw new RpcException(new Status(StatusCode.Internal, "User update failed"));
            }

            return _mapper.Map<IUserListDTO>(user);
        }

        public async Task Delete(Guid id)
        {
            IUser user = await _repository.GetDetail(id);

            if (user == null)
            {
                //ignore it
            }

            bool deleted = await _repository.Delete(user);

            if (!deleted)
            {
                //ignore it
            }
        }

        public Task<bool> Exists(Expression<Func<IUser, bool>> expression)
        {
            return _repository.Any(expression);
        }

        public async Task SaveChanges()
        {
            await _repository.SaveChanges();
        }
    }
}