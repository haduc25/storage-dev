<?php
#PHP Regular Expressions
echo "PHP Regular Expressions <br>";
/*
A regular expression is a sequence of characters that forms a search pattern. When you search for data in a text, you can use this search pattern to describe what you are searching for.
A regular expression can be a single character, or a more complicated pattern.
Regular expressions can be used to perform all types of text search and text replace operations.

*Syntax
In PHP, regular expressions are strings composed of delimiters, a pattern and optional modifiers.

//ex
	$exp = "/w3schools/i";

In the example above, / is the delimiter, w3schools is the pattern that is being searched for, and i is a modifier that makes the search case-insensitive.

The delimiter can be any character that is not a letter, number, backslash or space. The most common delimiter is the forward slash (/), but when your pattern contains forward slashes it is convenient to choose other delimiters such as # or ~
*/

#Regular Expression Functions
echo "PHP Regular Expression Functions <br>";
/*
PHP provides a variety of functions that allow you to use regular expressions. The preg_match(), preg_match_all() and preg_replace() functions are some of the most commonly used ones:

Function				Description
preg_match()			Returns 1 if the pattern was found in the string and 0 if not
preg_match_all()		Returns the number of times the pattern was found in the string, which may also be 0
preg_replace()			Returns a new string where matched patterns have been replaced with another string

*/

# preg_match() - function will tell you whether a string contains matches of a pattern.
echo "<br> Preg_match <br>";

$str = "i am from Vietnam";
$pattern = "/vietNam/i"; //su dung de tim chuoi (k phan biet chu hoa chu thuong)
echo "str = $str <br>";
echo "pattern = $pattern <br>";

echo preg_match($pattern, $str);

#preg_match_all() -  function will tell you how many matches were found for a pattern in a string.
echo "<br><br> Preg_match_all <br>";

$str1 = "The rain in SPAIN falls mainly on the plains";
$pattern1 = "/ain/i"; //tim kiem xem co bao nhieu kq phu hop

echo "str1 = $str1 <br>";
echo "pattern1 = $pattern1 <br>";

echo preg_match_all($pattern1, $str1);



#preg_replace() - function will replace all of the matches of the pattern in a string with another string.
echo "<br><br> Preg_replace <br>";

$str2 = "Ha Duc";
$pattern2 = "/ha/i";

echo "str2 = $str2 <br>";
echo "pattern2 = $pattern2 <br>";

echo preg_replace($pattern2, "Minh", $str2);


#Regular Expression Modifiers - Modifiers can change how a search is performed.
echo "<br><br> Regular Expression Modifiers <br>";
/*
Modifier						Description
i							-Performs a case-insensitive search (k phan biet chu hoa chu thuong)
m							-Performs a multiline search (patterns that search for the beginning or end of a string will match the 								beginning or end of each line) - (Thực hiện tìm kiếm nhiều dòng (các mẫu tìm kiếm phần đầu hoặc phần 								cuối của một chuỗi sẽ khớp với phần đầu hoặc phần cuối của mỗi dòng))
u							-Enables correct matching of UTF-8 encoded patterns - Cho phép đối sánh chính xác các mẫu được mã hóa 								UTF-8
*/

#Regular Expression Patterns - Brackets are used to find a range of characters:
echo "Regular Expression Patterns <br>";
/*
Expression						Description
[abc]						Find one character from the options between the brackets
[^abc]						Find any character NOT between the brackets
[0-9]						Find one character from the range 0 to 9
*/

#Metacharacters - Metacharacters are characters with a special meaning:
echo "Metacharacters <br>";
/*
Metacharacter					Description
|							Find a match for any one of the patterns separated by | as in: cat|dog|fish
.							Find just one instance of any character
^							Finds a match as the beginning of a string as in: ^Hello
$							Finds a match at the end of the string as in: World$
\d							Find a digit
\s							Find a whitespace character
\b							Find a match at the beginning of a word like this: \bWORD, or at the end of a word like this: WORD\b
\uxxxx						Find the Unicode character specified by the hexadecimal number xxxx
*/

#Quantifiers - Quantifiers define quantities:
echo "Quantifiers <br>";
/*
Quantifier						Description
n+							Matches any string that contains at least one n
n*							Matches any string that contains zero or more occurrences of n
n?							Matches any string that contains zero or one occurrences of n
n{x}						Matches any string that contains a sequence of X n's
n{x,y}						Matches any string that contains a sequence of X to Y n's
n{x,}						Matches any string that contains a sequence of at least X n's

Note: If your expression needs to search for one of the special characters you can use a backslash ( \ ) to escape them. For example, to search for one or more question marks you can use the following expression: $pattern = '/\?+/';
*/

#Grouping - You can use parentheses ( ) to apply quantifiers to entire patterns. They also can be used to select parts of the pattern to be used as a match.
echo "Grouping <br>";
/*
Use grouping to search for the word "banana" by looking for ba followed by two instances of na
*/

$str3 = "Apples and Bananas.";
$pattern3 = "/ba(na){2}/i";

echo "str3 = $str3 <br>";
echo "pattern3 = $pattern3 <br>";

echo preg_match($pattern3, $str3);

?>