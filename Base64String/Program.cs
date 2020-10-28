using System;
using System.Text;

namespace Base64String
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://tools.ietf.org/html/rfc4648#section-8
            //https://stackoverflow.com/questions/4080988/why-does-base64-encoding-require-padding-if-the-input-length-is-not-divisible-by#:~:text=In%20some%20circumstances%2C%20the%20use,to%20yield%20correct%20decoded%20data.&text=Padding%20allows%20us%20to%20decode,promise%20of%20no%20lost%20bits.

            string f =      "Zg"; 
            string fo =     "Zm8";
            string foo =    "Zm9v";
            string foob =   "Zm9vYg";
            string fooba =  "Zm9vYmE";
            string foobar = "Zm9vYmFy";


            string base64String = f.PadRight(f.Length + (4 - f.Length % 4) % 4, '=');            
            var base64ByteArray = Convert.FromBase64String(base64String);
            Console.WriteLine($"{Encoding.ASCII.GetString(base64ByteArray)}   -   {nameof(f)}    -   {f}  - {base64String}");


            base64String = fo.PadRight(fo.Length + (4 - fo.Length % 4) % 4, '=');            
            base64ByteArray = Convert.FromBase64String(base64String);
            Console.WriteLine($"{Encoding.ASCII.GetString(base64ByteArray)}   -   {nameof(fo)}    -   {fo}  - {base64String}");

            
            base64String = foo.PadRight(foo.Length + (4 - foo.Length % 4) % 4, '=');            
            base64ByteArray = Convert.FromBase64String(base64String);
            Console.WriteLine($"{Encoding.ASCII.GetString(base64ByteArray)}   -   {nameof(foo)}    -   {foo}  - {base64String}");

            
            base64String = foob.PadRight(foob.Length + (4 - foob.Length % 4) % 4, '=');            
            base64ByteArray = Convert.FromBase64String(base64String);
            Console.WriteLine($"{Encoding.ASCII.GetString(base64ByteArray)}   -   {nameof(foob)}    -   {foob}  - {base64String}");

            
            base64String = fooba.PadRight(fooba.Length + (4 - fooba.Length % 4) % 4, '=');            
            base64ByteArray = Convert.FromBase64String(base64String);
            Console.WriteLine($"{Encoding.ASCII.GetString(base64ByteArray)}   -   {nameof(fooba)}    -   {fooba}  - {base64String}");

            
            base64String = foobar.PadRight(foobar.Length + (4 - foobar.Length % 4) % 4, '=');            
            base64ByteArray = Convert.FromBase64String(base64String);
            Console.WriteLine($"{Encoding.ASCII.GetString(base64ByteArray)}   -   {nameof(foobar)}    -   {foobar}  - {base64String}");




        }
    }
}
