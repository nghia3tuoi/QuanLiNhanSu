namespace QLNS.Areas.Admin.Forms
{
    public class TaiKhoan
    {
        public string? id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password {get;set;}

        public DateTimeOffset? BlockOutEnd { get; set; }

    }
}