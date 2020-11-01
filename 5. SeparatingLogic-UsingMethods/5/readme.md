### Задание 5 ###

Вычислить, используя рекурсию, функцию Аккермана:<br/>
A(2, 5), A(1, 2)<br/>
A(n, m) = m + 1, если n = 0,<br/>
        = A(n - 1, 1), если n <> 0, m = 0,<br/>
        = A(n - 1, A(n, m - 1)), если n> 0, m > 0.<br/>

![Image alt](https://github.com/sergey-crusher/Skillbox_CSharp/blob/master/5.%20SeparatingLogic-UsingMethods/5/result.JPG) 