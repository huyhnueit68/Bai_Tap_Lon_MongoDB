# Phầm mềm quản lý thiết bị nhà K

## Mô Tả Phần Mềm

### Chức năng:

- Quản lý tài khoản và thông tin người dùng
- Quản lý danh mục thiết bị, nhóm thiết bị
- Quản lý việc mượn/trả thiết bị
- Quản lý việc thanh lý thiết bị
- Tìm kiếm thiết bị
- Thống kê trang thiết bị theo thời gian, theo người dùng
- Thông tin sử dụng thiết bị của từng người dùng
- Thống kê danh mục thiết thị thanh lý theo các ngày

### Ngỗn ngữ thiết kế và cơ sở dữ liệu:

- Ngôn ngữ lập trình: .NET C#
- Cở sở dữ liệu: MongoDB

### Ưu điểm phần mềm

- Sử dụng mô hình MVC đảm bảo clear code, dễ bảo trì
- validate dữ liệu chặt chẽ

## Thông tin tác giả

- Họ Tên: Phạm Quang Huy
- Mã Sinh Viên: 685105031

## Hướng dẫn cài đặt và sử dụng ứng dụng

#### Cài đặt cơ sở dữ liệu

> Cách 1:
> Tiến hành cài đặt cơ sở dữ liệu từ file bson và json
> trong thư mục Du Lieu/BackupDataBase
> Cách 2:
> Cài đặt CSDL bằng câu lệnh trên cmd
> Mở file createDataBase.txt và làm theo hướng dẫn

#### Cài đặt ứng dụng

> Ứng dụng sử dụng .NET C# thuần nên không cần cài đặt nhiều
> các thư viện sử dụng đã được đặt sẵn trong thư mục packages
> mở ứng dụng được đặt trong thư mục BTL MongoDB - Phần mềm quản lý thiết bị và mở file .sln

```
Lưu ý: sử dụng .NET FrameWork mới nhất để mở ứng dụng (phiên bản .NET 4.7.2)
Source Code trên github: https://github.com/huyhnueit68/Bai_Tap_Lon_MongoDB.git

```

## Chi tiết các chức năng

#### Quản lý tài khoản và thông tin người dùng

- Thông tin đầu vào:
  - Mã người dùng
  - Tên người dùng
  - Tên đăng nhập
  - Mật khẩu
  - Địa chỉ
  - Giới tính
  - Ngày Sinh
  - Mã nhóm người dùng
- Thông tin đầu ra:
  - Tìm kiếm theo mã người dùng, tên người dùng
  - Cập nhật thông tin: mật khẩu, ngày tháng năm sinh ...

#### Quản lý danh mục thiết bị, nhóm thiết bị

- Thông tin đầu vào:
  - Mã thiết bị
  - Tên thiết bị
  - Đơn giá
  - Chức năng
  - Phòng học
  - Trạng thái
  - Mã loại thiết bị
  - Tên loại thiết bị
- Thông tin đầu ra:
  - Kiểm tra tình trạng thiết bị
  - Tìm kiếm theo mã thiết bị, tên thiết bị, mã loại thiết bị, tên phòng học
  - Cập nhật thông tin: tên thiết bị, phòng học ...

#### Quản lý loại thiết bị

- Thông tin đầu vào:
  - Mã loại thiết bị
  - Tên loại thiết bị
- Thông tin đầu ra:
  - Tìm kiếm theo mã loại, tên loại thiết bị

#### Quản lý việc mượn/trả thiết bị

- Thông tin đầu vào:
  - Mã mượn
  - Ngày mượn
  - Ngày trả
  - Mã thiết bị mượn
  - Tên thiết bị mượn
  - Trạng thái
  - Mã khách hàng
  - Tên khách hàng
  - Mã nhóm khách hàng
- Thông tin đầu ra:
  - Mượn/trả thiết bị
  - Tìm kiếm theo mã mượn, mã thiết bị

#### Quản lý việc thanh lý thiết bị

- Thông tin đầu vào:
  - Mã thanh lý
  - Tên thanh lý
  - Mã thiết bị
  - Tên thiết bị
  - Ngày thanh lý
  - Phòng học
  - Mã loại thiết bị
- Thông tin đầu ra:
  - Thêm thanh lý thiết bị
  - Tìm kiếm theo mã thanh lý, tên thanh lý

#### Quản lý thống kê trang thiết bị

- Thống kê tổng số thiết bị đang được sử dụng
- Thống kê tổng số thiết bị đã được thanh lý
- Thống kê việc sử dụng theo thời
- Thông kê việc sử dụng theo tên
- Biển đồ tổng hợp tổng số thiết bị theo từng ngày
