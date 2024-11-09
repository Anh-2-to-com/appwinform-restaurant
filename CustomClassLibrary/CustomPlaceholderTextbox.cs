using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomClassLibrary
{
    public class CustomPlaceholderTextbox : TextBox
    {
        private string _placeholderText;
        private bool _isPlaceholderActive;

        public string PlaceholderText
        {
            get { return _placeholderText; }
            set
            {
                _placeholderText = value;
                ShowPlaceholder(); // Hiển thị placeholder khi thiết lập giá trị mới
            }
        }

        public CustomPlaceholderTextbox()
        {
            GotFocus += RemovePlaceholder;
            LostFocus += ShowPlaceholder;
            BackColor = Color.White;
            BorderStyle = BorderStyle.None;
            // Hiển thị placeholder khi control được tạo
            ShowPlaceholder();
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            _isPlaceholderActive = false;
            Text = ""; // Xóa placeholder khi TextBox có tiêu điểm
            ForeColor = Color.Black;
        }

        private void ShowPlaceholder(object sender = null, EventArgs e = null)
        {
            if (string.IsNullOrWhiteSpace(Text) && !string.IsNullOrEmpty(_placeholderText))
            {
                _isPlaceholderActive = true;
                Text = _placeholderText; // Hiển thị placeholder khi TextBox rỗng và không có tiêu điểm
                ForeColor = Color.Gray;
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ShowPlaceholder(); // Hiển thị placeholder khi control được tạo
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            // Nếu Text trống và không có tiêu điểm, hiển thị placeholder
            if (!Focused && string.IsNullOrWhiteSpace(Text))
            {
                ShowPlaceholder();
            }
            else
            {
                _isPlaceholderActive = false;
                ForeColor = Color.Black;
            }
        }
    }
}
