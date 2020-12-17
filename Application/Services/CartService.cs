using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repository;

namespace Application.Services
{
    public class CartService: ICartService
    {
        private readonly ICartRepository cartRepository;
        private readonly IMapper iMapper;
        public CartService(ICartRepository cartRepository, IMapper iMapper  )
        {
            this.cartRepository= cartRepository;
            this.iMapper= iMapper;
        }

        public void AddCartToDB(int IdThuCung,int Quantity,string UserName)
        {
            cartRepository.AddCartToDB(IdThuCung,Quantity,UserName);
        }

        public bool CheckTaiKhoan(string username, int id)
        {
                        return cartRepository.CheckTaiKhoan(username,id);

        }

        public IEnumerable<LoaiThuCungDTO> GetAll()
        {
            return iMapper.Map<IEnumerable<LoaiThuCung>,IEnumerable<LoaiThuCungDTO>>(cartRepository.GetLoai());
        }

        public IEnumerable<CartDBDTO> GetCart(string UserName)
        {
                        return iMapper.Map<IEnumerable<CartDB>,IEnumerable<CartDBDTO>>(cartRepository.GetCart(UserName));
        }

        public IEnumerable<CartDBDTO> GetCartNe(string username, int id)
        {
            return iMapper.Map<IEnumerable<CartDB>,IEnumerable<CartDBDTO>>(cartRepository.GetCartNe(username,id));

        }

        public IEnumerable<CartDBDTO> GetCheckOut(string UserName)
        {
            return iMapper.Map<IEnumerable<CartDB>,IEnumerable<CartDBDTO>>(cartRepository.GetCheckOut(UserName));
        }

        public int GetSl(string username, int id)
        {
            return cartRepository.GetSl(username,id);
        }

        public IEnumerable<ThuCungDTO> GetThuCung()
        {
                        return iMapper.Map<IEnumerable<ThuCung>,IEnumerable<ThuCungDTO>>(cartRepository.GetThuCung());
            
        }

        public ThuCungDTO GetThuCungToCart(int Id)
        {
            return iMapper.Map<ThuCung,ThuCungDTO>(cartRepository.GetThuCungToCart(Id));
        }

        public void RemoveCartToDB(int IdThuCung, string UserName)
        {
            cartRepository.RemoveCartToDB(IdThuCung,UserName);
        }

        

        public void UpdateToDB(string username,int Id, int Quantity)
        {
           cartRepository.UpdateToDB(username,Id,Quantity);
        }
    }
}