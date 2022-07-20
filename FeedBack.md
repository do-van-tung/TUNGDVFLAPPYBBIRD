# FeedBack

- Ưu điểm:
	+ Comment Code rõ ràng
	+ Tên biến đặt đầy đủ nghĩa
	+ Các hàm chức năng thực hiện 1 hoặc 2 chức năng
- Nhược điểm:
	+ Các hàm Update và FixUpdate chưa có điểm dừng.
	+ Tên biến chưa có phân cấp rõ ràng
	+ Code chưa có phần đa màn hình giao diện (Camera và Canvas).
- Đề xuất ý kiến cá nhân:
	+ Các hàm Update và FixUpdate nên cần có điểm dừng khi Game vào trạng thái GameOver hoặc Pause.
	+ Tên biến nên cần đặt tên sao cho phân biệt biến Local và Global (thêm các chữ "m" hoặc "_" trước biên global).
	+ Phần GameManager có thể đặt DontDestroy, chỉ cần khởi tạo 1 lần.