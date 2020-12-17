using System.Collections.Generic;
using Application.DTOs;


namespace mvcPet.Models
{
    public class ThuCungViewModel
    {
        public IEnumerable<LoaiThuCungDTO> GetAllLoai{ get; set; }
        public IEnumerable<BannerDTO> banner{ get; set; }
        public IEnumerable<LoaiThuCungDTO> PageList { get; set; }
        public IEnumerable<ThuCungDTO> PagePetList { get; set; }
        public IEnumerable<ThuCungDTO> thuCungs{ get; set; }
        public IEnumerable<ThuCungDTO> thuCung{ get; set; }
        public ThuCungDTO GetThuCungg { get; set; }
        public IEnumerable<ThuCungDTO> GetThuCung { get; set; }
        public IEnumerable<CartDBDTO> GetCart { get; set; }
        public string sortOrder { get; set; }
        public string SearchString { get; set; }
        public float GiaBan { get; set; }
    }
}