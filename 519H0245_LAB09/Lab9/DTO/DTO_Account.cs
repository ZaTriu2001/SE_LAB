namespace DTO
{
    public class DTO_Account
    {
        private string TenND, Matkhau, Quyen;

        public string _TENND
        {
            get
            {
                return TenND;
            }
            set
            {
                TenND = value;
            }
        }

        public string _MATKHAU
        {
            get
            {
                return Matkhau;
            }
            set
            {
                Matkhau = value;
            }
        }

        public string _QUYEN
        {
            get
            {
                return Quyen;
            }
            set
            {
                Quyen = value;
            }
        }

       
        public DTO_Account(string TenND, string Matkhau, string quyen)
        {
            this.TenND = TenND;
            this.Matkhau = Matkhau;
            this.Quyen = quyen;
        }
    }
}
