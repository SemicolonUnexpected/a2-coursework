using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework.Custom_Controls {
    internal static class CustomMessageBox {

        public static DialogResult Show(string text, string caption) {
            formCustomMessageBox messageBox = new(text, caption, MessageBoxButtons.OK);
            return messageBox.ShowDialog();
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons) {
            formCustomMessageBox messageBox = new(text, caption, buttons);
            return messageBox.ShowDialog();
        }
    }
}
