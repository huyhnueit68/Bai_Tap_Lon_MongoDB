var Rent = [
    {
        Id_Rent: 1,
        Date_Rent: new Date(2019 - 01 - 01),
        Date_Pay: new Date(2020 - 01 - 01),

        Id_Device: 1,
        Name_Device: "HP Omen 15inch",
        Room: "K505",

        Id_Type: 1,
        Status_Device: "Đang sử dụng",

        Id_Customer: 1,
        Name_Customer: "Admininstration",
        Id_Group: 1,
    },
    {
        Id_Rent: 2,
        Date_Rent: new Date(2019 - 01 - 01),
        Date_Pay: new Date(2020 - 01 - 01),

        Id_Device: 2,
        Name_Device: "HP Omen 15inch",
        Room: "K505",

        Id_Type: 2,
        Status_Device: "Đang sử dụng",

        Id_Customer: 2,
        Name_Customer: "Admininstration",
        Id_Group: 2,
    }
];

db.Rent_Device.insert(Rent);
