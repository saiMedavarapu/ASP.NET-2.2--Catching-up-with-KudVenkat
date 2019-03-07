Added a new file default.html
If we add default.html and run it. It will no do anything. We have to add useStaticfiles(); and UseDefaultFiles();
-------------------------------------------------
 if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
//This is the connection which acts as middlware
            
            app.UseStaticFiles();
            app.UseDefaultFiles();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello loli");
            });
---------------------------------------------------------

If we want to chose other file as startup file. Then we have to use  defaultfileOptions instance.
Step-1 create new instance
step-2 clear the previous connection
step-3 add new connection.

This is the connection which acts as middlware
    DefaultFilesOptions defaultfilesoptions = new DefaultFilesOptions();
    defaultfilesoptions.DefaultFileNames.Clear();//Clears the previous connection
    defaultfilesoptions.DefaultFileNames.Add("foo.html");
---------------------------------------------------------
 ![Alt text](SS.png) 
