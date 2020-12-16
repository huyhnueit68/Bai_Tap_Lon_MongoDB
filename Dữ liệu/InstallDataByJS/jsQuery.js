//query for form login
db.Account.find( { UserName_Customer: "admin", PassWord_Customer: "admin" } )


db.getCollection("Device").aggregate([
    {
        $group: {
            _id: "$Id_Device",
            Id_Device: { $first: "$Id_Device"},
            Name_Device: { $first: "$Name_Device" },
            Price_Device: { $first: "$Price_Device" },
            Function_Device: { $first: "$Function_Device"},
            Id_Type: { $first: "$Type_Device.Id_Type" },
            Room: { $first: "$Room" },
            Status_Device: { $first: "$Status_Device" }
        },
    },
    {
      $project: {
            Id_Device: 1,
            Name_Device: 1,
            Price_Device: 1,
            Function_Device: 1,
            Id_Type: 1,
            Room: 1,
            Status_Device: 1
        }
    },
]).pretty();


db.Rent_Device.find( { 
    $and: [ 
        { Date_Rent: { $gte: new Date("1900-10-01T00:00:00.000Z") } },
        { Date_Pay: { $lte: new Date("2021-10-01T00:00:00.000Z") } } 
    ]
})
    

db.Liquidate.aggregate([
   { $group: { 
           _id: "$Date_Liqui",
           total: { $sum: 1 } 
       } 
   },
   {
      $project: {
        total: 1
      }
   }
])