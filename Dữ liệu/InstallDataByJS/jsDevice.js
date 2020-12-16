var Device_Detail = [
    {
        Id_Device: 1,
        Name_Device: "HP Omen 15inch",
        Price_Device: 15000000,
        Function_Device: "Hiển thị màn hình",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Đang sử dụng"
    },
    {
        Id_Device: 2,
        Name_Device: "TOSIBA Omega x6",
        Price_Device: 15300000,
        Function_Device: "Cây máy tính",
        Id_Type: 1,
        Name_Type: "Cây máy tính",
        Room: "K505",
        Status_Device: "Đang sử dụng"
    },
    {
        Id_Device: 3,
        Name_Device: "LCD sata 3",
        Price_Device: 12300000,
        Function_Device: "Hiển thị màn hình",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Đang sử dụng"
    },
    {
        Id_Device: 4,
        Name_Device: "THDB LCD 15",
        Price_Device: 165423500,
        Function_Device: "Lưu trữ dữ liệu",
        Id_Type: 1,
        Name_Type: "Ổ cứng",
        Room: "K505",
        Status_Device: "Đang sử dụng"
    },
    {
        Id_Device: 5,
        Name_Device: "HNF Device",
        Price_Device: 123400000,
        Function_Device: "Hiển thị màn hình",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Đang sử dụng"
    },
    {
        Id_Device: 6,
        Name_Device: "ASUS A397PRO",
        Price_Device: 4521,
        Function_Device: "Hiển thị màn hình",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Đang sử dụng"
    },
    {
        Id_Device: 7,
        Name_Device: "LKJH KeyBoard",
        Price_Device: 125421,
        Function_Device: "Gõ phím",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Đang sử dụng"
    },
    {
        Id_Device: 8,
        Name_Device: "HJNFN fugi",
        Price_Device: 1561100,
        Function_Device: "Hiển thị màn hình",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Đang sử dụng"
    },
    {
        Id_Device: 9,
        Name_Device: "HNCHDN OLED",
        Price_Device: 250000000,
        Function_Device: "Hiển thị màn hình",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Đang sử dụng"
    },
    {
        Id_Device: 10,
        Name_Device: "HJMFM 898",
        Price_Device: 325000,
        Function_Device: "Hiển thị màn hình",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Đang sử dụng"
    },
    {
        Id_Device: 11,
        Name_Device: "HFGHD 987",
        Price_Device: 6851025,
        Function_Device: "Hiển thị màn hình",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Không sử dụng"
    },
    {
        Id_Device: 12,
        Name_Device: "FADSF 6532",
        Price_Device: 6513205,
        Function_Device: "Hiển thị màn hình",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Không sử dụng"
    },
    {
        Id_Device: 13,
        Name_Device: "HFHFRF 654",
        Price_Device: 5641315648,
        Function_Device: "Hiển thị màn hình",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Không sử dụng"
    },
    {
        Id_Device: 14,
        Name_Device: "HP HJ 8888",
        Price_Device: 18952355,
        Function_Device: "Hiển thị màn hình",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Không sử dụng"
    },
    {
        Id_Device: 15,
        Name_Device: "KJADF NET",
        Price_Device: 3265312,
        Function_Device: "Hiển thị màn hình",
        Id_Type: 1,
        Name_Type: "Màn hinh",
        Room: "K505",
        Status_Device: "Không sử dụng"
    }
];

db.Device.insert(Device_Detail);

var Type = [
    {
        Id_Type: 1,
        Name_Type: "Màn hình"
    },
    {
        Id_Type: 2,
        Name_Type: "Bàn phím"
    },
    {
        Id_Type: 3,
        Name_Type: "LapTop"
    },
    {
        Id_Type: 4,
        Name_Type: "Chuột"
    },
    {
        Id_Type: 5,
        Name_Type: "Main"
    },
    {
        Id_Type: 6,
        Name_Type: "Rom"
    },
    {
        Id_Type: 7,
        Name_Type: "Ổ cứng"
    },
    {
        Id_Type: 8,
        Name_Type: "RAM"
    },
    {
        Id_Type: 9,
        Name_Type: "USE"
    },
    {
        Id_Type: 10,
        Name_Type: "Máy Chiếu"
    },
    {
        Id_Type: 11,
        Name_Type: "Bảng"
    },
    {
        Id_Type: 12,
        Name_Type: "Phấn"
    },
    {
        Id_Type: 13,
        Name_Type: "Bàn"
    },
    {
        Id_Type: 14,
        Name_Type: "Ghế"
    },
    {
        Id_Type: 15,
        Name_Type: "Dây HDMI"
    },

];

db.Type_Device.insert(Type);
