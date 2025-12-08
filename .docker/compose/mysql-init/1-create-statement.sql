create database if not exists apidiflenhub;
use apidiflenhub;

create table users(
    id int primary key auto_increment,
    public_id varchar(255) not null,
    email varchar(50) not null,
    username varchar(30) not null,
    password varchar(255) not null,
    experience int default 0,
    status boolean default true,
    file_type varchar(30),
    profile_picture blob
)