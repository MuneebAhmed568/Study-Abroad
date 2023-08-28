For Backend


1) Enter your DB Connection String in appsettings.json
2) Run "dotnet ef migrations add InitialCreate" In Terminal of Backend
3) "dotnet ef database update" In Terminal of Backend
4) Run the Following Command in  Sql Server inide Db "insert into Verify_login  (Email,Password,identifier ) values( 'admin@gmail.com' ,'admin123',4)"


Admin user will be Created,Login Email= admin@gmail.com  and Password = admin123


For Frontend Read its Readme inside "/Study"

