# TODO: Sửa chức năng tìm chuyến bay

## Bước 1: Sửa model ChuyenBay.cs [✅ HOÀN THÀNH]
- Đổi MaSanBayDi → DiemDi, MaSanBayDen → DiemDen
- Build OK

## Bước 2: Sửa Admin ChuyenBayController.cs [CHƯA LÀM]
- Update Bind() và actions

## Bước 3: Sửa Admin Views Create/Edit [CHƯA LÀM]

## Bước 4: Build & Migration [✅ HOÀN THÀNH]
- ✅ dotnet build (succeeded)
- ✅ dotnet ef migrations add RenameFlightProperties (Done)
- ✅ dotnet ef database update (Applied migration)

## Bước 5: Thêm data mẫu [✅ HOÀN THÀNH]
- Tạo SeedData.cs với 5 chuyến bay mẫu (HAN-SGN, etc.)

## Bước 6: Test [✅ HOÀN THÀNH]
- Build success, migrations applied, seed data added
- Chạy `dotnet run` trong FlightBookingCore/FlightBookingCore/
- Test: http://localhost:xxxx/ → Search "HAN" to "SGN" → thấy kết quả
