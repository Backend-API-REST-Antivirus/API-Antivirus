
using Api_Antivirus.Data;
using Api_Antivirus.DTO;
using Api_Antivirus.Interface;
using Api_Antivirus.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Api_Antivirus.Services
{
    public class UsersService : IUsers
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;


        public UsersService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(UsersRequestDto dto)
        {
            var entity = _mapper.Map<users>(dto);
            _context.users.Add(entity);
            await _context.SaveChangesAsync();
            _mapper.Map<UsersRequestDto>(entity);
        }

        public async Task DeleteAsync(long id)
        {
            var entity = await _context.users.FindAsync(id);
            if (entity != null)
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<UsersResponseDto>> GetAllAsync()
        {
            var entities = await _context.users.ToListAsync();
            return _mapper.Map<IEnumerable<UsersResponseDto>>(entities);
        }

        public async Task<UsersResponseDto> GetByIdAsync(long id)
        {
            var entity = await _context.users.FindAsync(id);
            return _mapper.Map<UsersResponseDto>(entity);
        }

        public async Task UpdateAsync(long id, UsersRequestDto dto)
        {
            var entity = await _context.users.FindAsync(id);
            if (entity != null)
            {
                entity.name = dto.Name;
                entity.email = dto.Email;
                entity.password = dto.Password;
                entity.rol = dto.Rol;
                await _context.SaveChangesAsync();
            }
        }
    }
}