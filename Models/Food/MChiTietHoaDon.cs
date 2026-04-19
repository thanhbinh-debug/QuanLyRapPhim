namespace QuanLyRapPhim.Models.Food
{
    public class MChiTietHoaDon
    {
        private string maHD;
        private string maVe;
        private string maSanPham;
        private int soLuong;

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public string MaVe 
        {
            get { return maVe; }
            set { maVe = value; }
        }

        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
    }
}
