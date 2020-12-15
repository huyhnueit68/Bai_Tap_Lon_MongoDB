var Liqui = [
    {
        Id_Liqui: 1,
        Name_Liqui: "Thanh lý thiết bị hỏng",
        Date_Liqui: new Date("2020-01-01"),
        Id_Device: 16,
        Name_Device: "HP Omen 15inch",
        Room: "K505",
        Id_Type: 1
    },
    {
        Id_Liqui: 2,
        Name_Liqui: "Thanh ổ cứng",
        Date_Liqui: new Date("2019-12-14"),
        Id_Device: 17,
        Name_Device: "Hard santa",
        Room: "K507",
        Id_Type: 2
    },
    {
        Id_Liqui: 3,
        Name_Liqui: "Thanh ổ cứng 2",
        Date_Liqui: new Date("2019-12-14"),
        Id_Device: 18,
        Name_Device: "Hard santa 300",
        Room: "K507",
        Id_Type: 2
    }
];

db.Liquidate.insert(Liqui);
