var Liqui = [
    {
        Id_Liqui: 1,
        Name_Liqui: "Thanh lý thiết bị hỏng",
        Date_Liqui: new Date(2020 - 01 - 01),
        Device: {
            Id_Device: 1,
            Name_Device: "HP Omen 15inch",
            Room: "K505",
            Id_Type: 1
        }
    }
];

db.Liquidate.insert(Liqui);
