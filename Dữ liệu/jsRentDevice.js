var Rent = [
    {
        Id_Rent: 1,
        Date_Rent: new Date("2019-01-01"),
        Date_Pay: new Date("2020-01-01"),

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
        Date_Rent: new Date("2019-11-12"),
        Date_Pay: new Date("2020-02-09"),

        Id_Device: 2,
        Name_Device: "TOSIBA Omega x6",
        Room: "K505",

        Id_Type: 2,
        Status_Device: "Đang sử dụng",

        Id_Customer: 2,
        Name_Customer: "Pham Quang Huy",
        Id_Group: 2,
    },
     {
        Id_Rent: 3,
        Date_Rent: new Date("2019-05-06"),
        Date_Pay: new Date("2020-11-02"),

        Id_Device: 3,
        Name_Device: "LCD sata 3",
        Room: "K505",

        Id_Type: 2,
        Status_Device: "Đang sử dụng",

        Id_Customer: 2,
        Name_Customer: "Pham Quang Huy",
        Id_Group: 2,
    },
      {
        Id_Rent: 4,
        Date_Rent: new Date("2019-02-11"),
        Date_Pay: new Date("2020-02-01"),

        Id_Device: 4,
        Name_Device: "THDB LCD 15",
        Room: "K505",

        Id_Type: 2,
        Status_Device: "Đang sử dụng",

        Id_Customer: 2,
        Name_Customer: "Pham Quang Huy",
        Id_Group: 2,
    },
       {
        Id_Rent: 5,
        Date_Rent: new Date("2019-02-12"),
        Date_Pay: new Date("2020-11-12"),

        Id_Device: 5,
        Name_Device: "HNF Device",
        Room: "K505",

        Id_Type: 2,
        Status_Device: "Đang sử dụng",

        Id_Customer: 2,
        Name_Customer: "Pham Quang Huy",
        Id_Group: 2,
    }
];

db.Rent_Device.insert(Rent);
