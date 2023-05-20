
CREATE TABLE [dbo].[teacher] (
    [tID]      INT           IDENTITY (1, 1) NOT NULL,
    [fname]    VARCHAR (MAX) NULL,
    [gender]   VARCHAR (MAX)  NULL,
    [dob]      date  NULL,
    [mobile]   VARCHAR(MAX)   NULL,
    [email]    VARCHAR (MAX) NULL,
    [semester] VARCHAR (MAX) NULL,
    [prog]     VARCHAR (MAX) NULL,
    [yer]      VARCHAR (MAX) NULL,
    [adr]      VARCHAR (500) NULL,
    CONSTRAINT [PK_teacher] PRIMARY KEY CLUSTERED ([tID] ASC)
);


 fname,gender,dob,mobile,email,semester,prog,yer,adr

select * from teacher
