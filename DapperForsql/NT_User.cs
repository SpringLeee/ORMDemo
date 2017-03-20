using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public partial class NT_User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int UserGender { get; set; }
        public int UserAge { get; set; }
        public string UserCompName { get; set; }
        public string UserCompAddr { get; set; }
        public string UserCompTel { get; set; }
        public string UserCompFax { get; set; }
        public string UserMobile { get; set; }
        public string UserWeb { get; set; }
        public string UserMSN { get; set; }
        public string UserQQ { get; set; }
        public string UserSKYPE { get; set; }
        public string UserJob { get; set; }
        public string UserDiscount { get; set; }
        public int UserService { get; set; }
        public int UserServices1 { get; set; }
        public int UserServices2 { get; set; }
        public int UserServices3 { get; set; }
        public int UserServices4 { get; set; }
        public int UserServices5 { get; set; }
        public int UserLanguage1 { get; set; }
        public int UserLanguage2 { get; set; }
        public int UserLanguage3 { get; set; }
        public string UserPro { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public string LastLoginIP { get; set; }
        public int LoginTimes { get; set; }
        public int Province { get; set; }
        public int City { get; set; }
        public Nullable<System.DateTime> RegTime { get; set; }
        public string RegIP { get; set; }
        public Nullable<int> Portrait { get; set; }
        public Nullable<int> InviterID { get; set; }
        public string VerifyCode { get; set; }
        public Nullable<System.DateTime> ConfirmTime { get; set; }
        public Nullable<bool> Recommended { get; set; }
        public Nullable<int> integral { get; set; }
        public Nullable<int> inteyb { get; set; }
        public Nullable<int> Kid { get; set; }
        public Nullable<int> Click { get; set; }
        public bool IsVip { get; set; }
        public int UserType { get; set; }
        public int FriendPlaces { get; set; }
        public int OutFriends { get; set; }
        public int ClnCurrency { get; set; }
    }

    public partial class NT_Photo
    {
        public int PhotoID { get; set; }
        public int AlbumID { get; set; }
        public int UploadUser { get; set; }
        public string Description { get; set; }
        public int Views { get; set; }
        public int FileSize { get; set; }
        public int State { get; set; }
        public bool IsCover { get; set; }
        public int Comments { get; set; }
        public System.DateTime PostTime { get; set; }
        public string PostIP { get; set; }
        public bool IsLock { get; set; }
        public int PhotoType { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Height { get; set; }
        public string FilePath { get; set; }
    }
