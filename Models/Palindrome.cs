using Microsoft.AspNetCore.Components.Forms;

namespace TattarrattatMVC.Models
{
    public class Palindrome
    {
        public string InputWord { get; set; }

        public string RevWord { get; set; }

        public bool IsPalindrome { get; set; }

        public string Message { get; set; }
    }
}
