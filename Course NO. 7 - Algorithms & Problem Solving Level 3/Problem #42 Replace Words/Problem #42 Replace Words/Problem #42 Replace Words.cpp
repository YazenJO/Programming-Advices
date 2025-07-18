#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

string ReadString() {
    string S1;
    cout << "Please Enter Your String?\n";
    getline(cin, S1);
    return S1;
}

vector<string> SplitString(string S1, string Delim) {
    vector<string> vString;
    short pos = 0;
    string sWord;

    while ((pos = S1.find(Delim)) != std::string::npos) {
        sWord = S1.substr(0, pos);
        if (sWord != "") {
            vString.push_back(sWord);
        }
        S1.erase(0, pos + Delim.length());
    }
    if (S1 != "") {
        vString.push_back(S1);
    }
    return vString;
}

string LowerString(const string& s1) {
    string s2 = "";
    for (int i = 0; i < s1.length(); i++)
        s2 += tolower(s1[i]);
    return s2;
}

string ReplaceWords(string s1, string ReplaceFrom, string ReplaceTo, bool MatchCase) {
    vector<string> Words = SplitString(s1, " ");
    string Result = "";
    vector<string>::iterator it = Words.begin();

    while (it != Words.end()) {
        if (MatchCase) {
            if (*it == ReplaceFrom)
                *it = ReplaceTo;
        }
        else {
            if (LowerString(*it) == LowerString(ReplaceFrom))
                *it = ReplaceTo;
        }
        Result += *it + " ";
        ++it;
    }
    return Result.substr(0, Result.length() - 1);
}

int main() {
    string S1 = "Yazen Bilal Ahmed Bilal";
    vector<string> S2 = SplitString(S1, " ");
    vector<string>::iterator word = S2.begin();

    cout << S1 << endl;
    cout << ReplaceWords(S1, "bilal", "GG", false);

    return 0;
}
