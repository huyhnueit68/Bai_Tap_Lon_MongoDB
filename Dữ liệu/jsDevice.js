var Device_Detail = [
    {
        Id_Device: 1,
        Name_Device: "HP Omen 15inch",
        Price_Device: 15000000,	
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
];

db.Type_Device.insert(Type);
