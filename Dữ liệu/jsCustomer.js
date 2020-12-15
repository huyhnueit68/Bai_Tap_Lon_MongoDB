var Customer_Detail = [
    {
        Id_Customer: 1,
        UserName_Customer: "admin",
        PassWord_Customer: "admin",
        Name_Customer: "Administration",
        Address_Customer: "Xuân Thủy, Cầu Giấy, Hà Nội",
        Grender_Customer: "Nam",
        Birthday_Customer: new Date("2000-12-14"),
        Id_Group: 1
    },
    {
        Id_Customer: 2,
        UserName_Customer: "huy123123",
        PassWord_Customer: "ahfgrudj",
        Name_Customer: "Vũ Quang Huy",
        Address_Customer: "197 Xuân Thủy, Cầu Giấy, Hà Nội",
        Grender_Customer: "Nam",
        Birthday_Customer: new Date("2001-11-14"),
        Id_Group: 2
    },
    {
        Id_Customer: 3,
        UserName_Customer: "HuyHnueIT",
        PassWord_Customer: "HuyHnueIT",
        Name_Customer: "Pham Quang Huy",
        Address_Customer: "199 Trần Quốc Hoàn, Cầu Giấy, Hà Nội",
        Grender_Customer: "Nam",
        Birthday_Customer: new Date("1998-11-14"),
        Id_Group: 2
    },
    {
        Id_Customer: 4,
        UserName_Customer: "hang1243984",
        PassWord_Customer: "gjdnrf",
        Name_Customer: "Vu Thi Hang",
        Address_Customer: "64 Nguyễn Cơ Thạch, Mỹ Đình, Hà Nội",
        Grender_Customer: "Nữ",
        Birthday_Customer: new Date("1998-10-20"),
        Id_Group: 2
    },
    {
        Id_Customer: 5,
        UserName_Customer: "Long5345",
        PassWord_Customer: "gjdnrgf",
        Name_Customer: "Pham Quoc Long",
        Address_Customer: "175 Hoàng Mai, Hà Nội",
        Grender_Customer: "Nam",
        Birthday_Customer: new Date("1989-11-14"),
        Id_Group: 2
    },
    {
        Id_Customer: 6,
        UserName_Customer: "Trang180920",
        PassWord_Customer: "trang1809",
        Name_Customer: "Nguyễn Mai Trang",
        Address_Customer: "36 Giáp bát, Hà Nội",
        Grender_Customer: "Nữ",
        Birthday_Customer: new Date("2000-09-18"),
        Id_Group: 2
    },
    {
        Id_Customer: 7,
        UserName_Customer: "Huyen534534",
        PassWord_Customer: "hkfhrjn",
        Name_Customer: "Nguyễn Ngọc Huyền",
        Address_Customer: "199 Trần Quốc Hoàn, Cầu Giấy, Hà Nội",
        Grender_Customer: "Nữ",
        Birthday_Customer: new Date("2000-11-05"),
        Id_Group: 2
    },
    {
        Id_Customer: 8,
        UserName_Customer: "Huy5678",
        PassWord_Customer: "hjmknd",
        Name_Customer: "Pham Quang Huy",
        Address_Customer: "199 Trần Quốc Hoàn, Cầu Giấy, Hà Nội",
        Grender_Customer: "Nam",
        Birthday_Customer: new Date("2000-11-14"),
        Id_Group: 2
    },
    {
        Id_Customer: 9,
        UserName_Customer: "Phuong56789",
        PassWord_Customer: "phuonglkjn",
        Name_Customer: "Nguyễn Minh Phương",
        Address_Customer: "199 Trần Quốc Hoàn, Cầu Giấy, Hà Nội",
        Grender_Customer: "Nam",
        Birthday_Customer: new Date("2002-03-14"),
        Id_Group: 2
    },
    {
        Id_Customer: 10,
        UserName_Customer: "Thai09876",
        PassWord_Customer: "tyujm",
        Name_Customer: "Nguyễn Văn Thái",
        Address_Customer: "199 Trần Quốc Hoàn, Cầu Giấy, Hà Nội",
        Grender_Customer: "Nam",
        Birthday_Customer: new Date("1999-10-10"),
        Id_Group: 2
    },
    {
        Id_Customer: 11,
        UserName_Customer: "Nga67898",
        PassWord_Customer: "ghjkm",
        Name_Customer: "Nguyễn Thị Nga",
        Address_Customer: "175 Đình Thôn, Mỹ Đình, Hà Nội",
        Grender_Customer: "Nữ",
        Birthday_Customer: new Date("1995-11-14"),
        Id_Group: 2
    },
    {
        Id_Customer: 12,
        UserName_Customer: "Hang7897",
        PassWord_Customer: "gkjkukm",
        Name_Customer: "Nguyễn Thị Hằng",
        Address_Customer: "Ngoại giao đoàn, Ba Đình, Hà Nội",
        Grender_Customer: "Nam",
        Birthday_Customer: new Date("1998-11-14"),
        Id_Group: 2
    },
    {
        Id_Customer: 13,
        UserName_Customer: "Khang078",
        PassWord_Customer: "hjkiuk",
        Name_Customer: "Nguyễn Văn Khang",
        Address_Customer: "236 Xuân Thủy, Cầu Giấy Hà Nội",
        Grender_Customer: "Nam",
        Birthday_Customer: new Date("1998-10-05"),
        Id_Group: 2
    },
    {
        Id_Customer: 14,
        UserName_Customer: "Ly9876789",
        PassWord_Customer: "uyikmn",
        Name_Customer: "Nguyễn Cẩm Ly",
        Address_Customer: "Chung cư BQP X20, Hoàng Mai, Hà Nội",
        Grender_Customer: "Nữ",
        Birthday_Customer: new Date("2001-10-12"),
        Id_Group: 2
    },
    {
        Id_Customer: 15,
        UserName_Customer: "Vu9876789",
        PassWord_Customer: "yuikm",
        Name_Customer: "Nguyễn Văn Vũ",
        Address_Customer: "87 Xuân Thủy, Cầu Giấy, Hà Nội",
        Grender_Customer: "Nam",
        Birthday_Customer: new Date("1999-12-03"),
        Id_Group: 2
    }
];

db.Customer.insert(Customer_Detail);

var Customer_Group = [
    {
        Id_Group: 1,
        Name_Group: "Administration"
    },
    {
        Id_Group: 2,
        Name_Group: "Customer"
    },
];

db.Group_Customer.insert(Customer_Group);
