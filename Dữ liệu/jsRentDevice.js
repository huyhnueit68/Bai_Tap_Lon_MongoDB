var Rent = [
    {
        Id_Rent: 1,
        Date_Rent: new Date(2019 - 01 - 01),
        Date_Pay: new Date(2020 - 01 - 01),
        Device: {
            Id_Device: 1,
            Name_Device: "HP Omen 15inch",
            Room: "K505",
            Id_Type: 1,
            Status_Device: "Đang sử dụng"
        },
        Customer: {
            Id_Customer: 1,
            Name_Customer: "Admininstration",
            Id_Group: 1
        },
    }
];

db.Rent_Device.insert(Rent);
