namespace _09._10._24_Ceasar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*====
            Transpose the characters in the message A-Z by a user inputted value ----------------// ABCXYZ --> DEFABC but abcxyz --> JKLabc
            
            Ignore all other characters (let them remain in place)                   -----// get onto that now

            The alphabet A-Z should loop round (i.e. a shift of 3 should mean X --> A and B --> E)

            Give the user the option of encoding or decoding a message         -----// Done.

            Return an encrypted or decrypted message           ------------// Done. some bugs
            ====*/


            string plainText = string.Empty;
            string cipherText = string.Empty;
            int cipherKey = 0;
            int choice = 0;
            bool isOutOfRange = false;
            int dec = 0;

            Console.Write("Would you like to encrypt (1) or decrypt (2)? : "); //"Would you like to [e]ncrypt or [d]ecrypt? : "
            choice = Convert.ToInt16(Console.ReadLine());

            Console.Write("Key : ");
            cipherKey = Convert.ToInt16(Console.ReadLine()) %26 ; // use mod for when Key > 26

            if (choice == 1)
            {
                plainText = Console.ReadLine();
                foreach (var letter in plainText) // to encrypt // lowercase encyption is buggy when handling unwrapped // ik whats wrong, the bool is true for some reason?
                {
                    if (char.IsLetter(letter))
                    {
                        isOutOfRange = false;
                        dec = (int)letter;
                        if (dec + cipherKey > 90 && dec > 64 || dec + cipherKey > 121 && dec > 96)
                        {
                            isOutOfRange = true;
                        }

                        if (isOutOfRange)
                        {
                            cipherText += (char)(dec - 26 + cipherKey);
                        }

                        else
                        {
                            cipherText += (char)(dec + cipherKey);
                        }
                    }
                }
            }

            else
            {
                cipherText = Console.ReadLine();
                foreach (var letter in cipherText) // to decrypt // uppercase decryption is buggy when handling unwrapped
                {
                    if (char.IsLetter(letter))
                    {
                        isOutOfRange = false;
                        dec = (int)letter;
                        if (dec - cipherKey < 65 && dec > 91 || dec - cipherKey < 97 && dec < 122)
                        {
                            isOutOfRange = true;
                        }

                        if (isOutOfRange)
                        {
                            plainText += (char)(dec + 26 - cipherKey);
                        }

                        else
                        {
                            plainText += (char)(dec - cipherKey);
                        }
                    }
                }
            }
            
            Console.WriteLine(plainText);
            Console.WriteLine(cipherText);
        }
    }
}

/*
Jasper's code snippet

key = cr % 26

int asciicode;
forech (car c in plaintext)
{
    asciicode = (int)c;
    if (char.IsLetter(c))
    {
        asciicode += key
        if (asciicode > 90)
        {
            asciicode -= 26
        }
    }
    ciphertext += (char)asciicode
}
 */