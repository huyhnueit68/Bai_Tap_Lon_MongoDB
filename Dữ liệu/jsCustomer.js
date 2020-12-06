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
        UserName_Customer: "HuyHnueIT",
        PassWord_Customer: "HuyHnueIT",
        Name_Customer: "Pham Quang Huy",
        Address_Customer: "199 Trần Quốc Hoàn, Cầu Giấy, Hà Nội",
        Grender_Customer: "Nam",
        Birthday_Customer: new Date("1998-11-14"),
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
