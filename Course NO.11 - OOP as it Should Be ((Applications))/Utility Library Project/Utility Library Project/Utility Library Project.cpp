#include <iostream>
#include "clsUtil.h"

int main()

{
    string TextAfterEncryption, TextAfterDecryption;
    string Text = "1234";
    TextAfterEncryption = clsUtil::EncryptText(Text, 2);
    TextAfterDecryption = clsUtil::DecryptText(TextAfterEncryption, 2);

    cout << "\nText Before Encryption : ";
    cout << Text << endl;
    cout << "Text After Encryption  : ";
    cout << TextAfterEncryption << endl;
    cout << "Text After Decryption  : ";
    cout << TextAfterDecryption << endl;

    system("pause>0");

    return 0;
}