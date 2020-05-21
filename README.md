# My-Dictionary
## Turkish-English Dictionary
16.05.2020 <br/>
My Dictionary <br/>
Z.Yusuf Gültaç <br/>
ygultac@hotmail.com <br/>

### I. Project Purpose
The purpose of this project is to examine the shortcomings of other similar dictionary applications and to provide the user with the shortest and most comfortable solution. I aimed for an application that users can easily use in online and offline environments, easily access the search history and access the data what they want.
The mobile application or internet site versions of this project will be more useful, but I have no technical knowledge on these subjects, I applied my C#  knowledges what I learned during the university education period in this project.
The application is aimed at users who want to translate between English and Turkish languages.I want to create other versions of the application I mentioned above in the future.


### II. Project Accomplishments
I used and learned
“Microsoft Sql Server ” to store data and create necessary queries.
"Html Agility Pack" for getting word from website.
“Smtp” (Simple Mail Transfer Protocol) library used by users to report their positive or negative opinions via mail.
"Regex" for testing the format of the mail written.
"using System.Data.SqlClient" library to communicate with the Data Server.
Show / Hide password method.
I did not use API service in the project due to financial means. I want to accomplish this in the future with financial support

### III. Project Challenges and Lessons Learned
It took my time to solve the problems I encountered during the project due to inexperience. The methods, libraries and features what I used in the project will make my job easier in the next projects or updates.
I would like to make mobile and website versions of the application in terms of comfort of use. This is my advice to people who will do this.



### IV.Project introduction
There is a login section at the start. If user is not yet a member, there is a section where user will create a new account.

![Ekran Görüntüsü (81)](https://user-images.githubusercontent.com/62885850/82614921-4c5b3900-9bc9-11ea-8919-e94ebd71b09b.png)
    
**Login Form**
                                                   
**Singup Form**

                                                 
             
If the password or username is not correct in the login section, the application gives a warning. Similar feature is valid in the registration form. If the required values are not entered, registration will not be completed. The size of the user name, checking the mail format, and automatic correction of the date of birth are performed automatically by the system. The user can easily check his password in the login section.
Search Form
       
There are different types of tabs at the top of the main form. I used toolstrip here and changed the design myself. There is a button and a textbox in the section where you can search. The datagridwiev table where you can see the results is under this section. The night mode feature in the right corner is created for users who want to use the application in different color formats. At the bottom there is a part which is the word of the day. This part comes from the internet.    

 

The word comes from "Microsoft Sql Server". The relationship between the query system and the written value is checked and the result is shown in the table. You can easily transfer this value to the favorites table by clicking the right mouse button.

**Favoruties Form**
 
You can edit in the favoruties form that is to say remove unnecessary words from the table by clicking the right mouse button. I used the "Context Menu Strip" tool to do this.

**History Form**
 

You can edit in the history form that is to say add words from the table to favoruties form by clicking the right mouse button. I used the "Context Menu Strip" tool to do this.

**Feedback Form**
                                    

Users can send password reset requests, updating user information, report requests and suggestions to developers from this section. Users will be able to contact the authorities. I used “Smtp” (Simple Mail Transfer Protocol)  in this section.
About us
                                      
The user can find information about the application in this section. After editing the settings part of the application, I put it into the about form with the help of method.
 

Dark mode is a feature that the user can use in environments with low light to avoid eye strain. Most applications use this feature today.


