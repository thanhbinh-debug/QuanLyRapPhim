namespace QuanLyRapPhim.Models
{
    public class MHoaDon
    {
        #region HoaDon
        private List<MVe> dsVe= new List<MVe>();
        private List<MSanPham> dsDoAn = new List<MSanPham>();
        #endregion

        #region Property HoaDon
        public List<MVe> DsVe
        {
            get { return dsVe; }
            set { dsVe = value; }
        }
        public List<MSanPham> DsDoAn
        {
            get { return dsDoAn; }
            set { dsDoAn = value; }
        }
        #endregion

         #region Methods HoaDon
        private double TinhTongTien()
        {
            double tong = 0;
            foreach (var ve in dsVe) tong += ve.Gia;
            foreach (var sp in dsDoAn) tong += sp.Gia;
            return tong;
        }

       public void InHoaDon()
        {
            Console.WriteLine("Hóa Đơn:");
            Console.WriteLine("Vé:");
            foreach (var ve in dsVe) Console.WriteLine($"- Ghế: {ve.Ghe}, Suất: {ve.SuatChieu}, Giá: {ve.Gia}");
            Console.WriteLine("Đồ Ăn:");
            foreach (var sp in dsDoAn) Console.WriteLine($"- Sản Phẩm: {sp.TenSP}, Giá: {sp.Gia}");
            Console.WriteLine($"Tổng Tiền: {TinhTongTien()}");
        }
        #endregion
    }
}
