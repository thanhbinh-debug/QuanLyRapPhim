namespace QuanLyRapPhim.Models
{
    public class MGhe
    {
        #region Gheeee
        private int soGhe;
        private bool daDat;
        private string trangThai { get; set; }
        #endregion
        // khai property để có thể truy xuất sửa đổi dữ liệu
        #region Property Gheeee
        public int SoGhe
        {
            get { return soGhe; }
            set { soGhe = value; }
        }
        public bool DaDat
        {
            get { return daDat; }
            set { daDat = value; }
        }
        #endregion
    }
}
