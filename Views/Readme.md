If we call any view method and return a view object without creating the .cshtml file it will give the kestral error. 

To fix it. Create a new folder, views(if you dont have one) and insert a folder with name of your controller in it. 

Inside that create a file with .cshtml extension and give it a name of method which you are returnin the view object to.


