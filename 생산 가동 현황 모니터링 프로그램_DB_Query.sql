CREATE DATABASE sscompany;
USE sscompany;

CREATE TABLE user_info (
	uid CHAR(12) PRIMARY KEY,
	upw CHAR(14) NOT NULL,
	uname CHAR(5) NOT NULL,
	ubirth CHAR(10) NOT NULL,
	ugender CHAR(1) NOT NULL,
	uadress VARCHAR(100) NULL,
	uphone1 CHAR(3) NOT NULL,
	uphone2 CHAR(4) NOT NULL,
	uphone3 CHAR(4) NOT NULL
);
CREATE TABLE user_image (
	fid CHAR(12),
	xPos SMALLINT UNSIGNED NOT NULL,
	yPos SMALLINT UNSIGNED NOT NULL,
	r TINYINT UNSIGNED NOT NULL,
	g TINYINT UNSIGNED NOT NULL,
	b TINYINT UNSIGNED NOT NULL,
	height SMALLINT UNSIGNED,
	width SMALLINT UNSIGNED,
	FOREIGN KEY(fid) REFERENCES user_info(uid)
);
CREATE TABLE commuting_time (
	아이디 CHAR(12) NOT NULL,
	이름 CHAR(5) NOT NULL,
	출근시간 DATETIME,
	퇴근시간 DATETIME,
	작업라인 CHAR(2),
	책임유무 ENUM('Yes', 'No'),
	FOREIGN KEY(아이디) REFERENCES user_info(uid)
);
CREATE TABLE total_commuting_time (
	아이디 CHAR(12) NOT NULL,
	이름 CHAR(5) NOT NULL,
	출근시간 DATETIME,
	퇴근시간 DATETIME,
	책임유무 ENUM('Yes', 'No'),
	FOREIGN KEY(아이디) REFERENCES user_info(uid)
);
CREATE TABLE pro_info (
	설비번호 CHAR(3) PRIMARY KEY,
	설비명 VARCHAR(20), 
	설비상태 ENUM('가동', '비가동'),
	책임자 VARCHAR(10),
	품목명 VARCHAR(20),
	품목번호 VARCHAR(20),
	작업시간 CHAR(7),
	목표량 INT,
	생산수량 INT,
	불량수량 INT
);