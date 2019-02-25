This is for geting notification of website for windows if you didn't have access to spesific website. If you have access to a web, using this method is not recomended because the large bandwith it use. You probably need to use observer / notification pattern instead.

This method usually called scraping.

For this application to work  HTMLAgility Pack needed :
[HTMLAgility Pack](https://html-agility-pack.net/)

How this works:

First it's download web page.
Search node of web you specify (id or class)
Scrap all of node content.
Save it using serialization.
If five minutes later the content is different, it send notification to windows.

Note :
This doesn't work if application using generated node content (Some social media using generated node for security purpose, except if you using API it served)