-- T_Magazines Table
CREATE TABLE T_Magazines (
  magazine_id INT NOT NULL,
  user_id INT NOT NULL,
  magazine_title VARCHAR2(200) NOT NULL,
  magazine_category VARCHAR2(200),
  magazine_price NUMBER(12, 2) NOT NULL,
  publish_date DATE,
  updated_at DATE,
  magazine_img_url NVARCHAR2(200),
  CONSTRAINT T_Magazines_PK PRIMARY KEY (magazine_id),
  CONSTRAINT T_Magazines_FK_Magazine FOREIGN KEY (user_id) REFERENCES T_Users(user_id)
);

-- T_Users Table
CREATE TABLE T_Users (
  user_id INT NOT NULL,
  username VARCHAR2(100) NOT NULL,
  email VARCHAR2(200) NOT NULL,
  password VARCHAR2(100),
  gender CHAR(4),
  role VARCHAR2(50) DEFAULT 'user',
  created_at DATE,
  updated_at DATE,
  CONSTRAINT T_Users_PK PRIMARY KEY (user_id),
  CONSTRAINT T_Users_UQ_Email UNIQUE (email)
);


-- T_Subscriptions Table
CREATE TABLE T_Subscriptions (
  subscription_id INT NOT NULL,
  user_id INT NOT NULL,
  magazine_id INT NOT NULL,
  start_date DATE,
  subscribe_until DATE,
  CONSTRAINT T_Subscriptions_PK PRIMARY KEY (subscription_id),
  CONSTRAINT T_Subscriptions_FK_User FOREIGN KEY (user_id) REFERENCES T_Users(user_id),
  CONSTRAINT T_Subscriptions_FK_Magazine FOREIGN KEY (magazine_id) REFERENCES T_Magazines(magazine_id) ON DELETE CASCADE
);


-- T_Magazine_Interactions Table
CREATE TABLE T_Magazine_Interactions (
  interaction_id INT NOT NULL,
  user_id INT NOT NULL,
  magazine_id INT NOT NULL,
  feedback VARCHAR2(500),
  rating CHAR(1), -- out of 5
  CONSTRAINT T_Interactions_PK PRIMARY KEY (interaction_id),
  CONSTRAINT T_Interactions_FK_User FOREIGN KEY (user_id) REFERENCES T_Users(user_id) ON DELETE CASCADE,
  CONSTRAINT T_Interactions_FK_Magazine FOREIGN KEY (magazine_id) REFERENCES T_Magazines(magazine_id)
);




-------------------- PROCEDURES -----------------------------

create or replace PROCEDURE FETCH_MAGAZINE
( mag_id IN OUT NUMBER
, mag_title OUT VARCHAR2
, mag_price OUT NUMBER
, mag_category OUT VARCHAR2
, mag_createdAt OUT DATE
, mag_updatedAt OUT DATE
, mag_image_url OUT VARCHAR2
) AS
BEGIN
  SELECT magazine_id, magazine_title, magazine_price, magazine_category, publish_date, updated_at, magazine_img_url
  INTO mag_id, mag_title, mag_price, mag_category, mag_createdAt, mag_updatedAt, mag_image_url
  FROM T_Magazines
  WHERE magazine_id = mag_id;
END FETCH_MAGAZINE;
/


create or replace PROCEDURE FETCH_MAGAZINES_IDS(mag_id out Sys_refCursor) AS
BEGIN
open mag_id for
select MAGAZINE_ID 
from t_magazines;
END;
/



--------- INSERT STATEMENTS -------------
-- T_USERS
    
INSERT INTO T_Users (username, email, password, gender, role, created_at, updated_at)
VALUES ('belal', 'belal@email.com', 'pass123', 'M', 'user', SYSDATE, SYSDATE);

INSERT INTO T_Users (username, email, password, gender, role, created_at, updated_at)
VALUES ('sara', 'sara@email.com', 'pass456', 'F', 'user', SYSDATE, SYSDATE);

INSERT INTO T_Users (username, email, password, gender, role, created_at, updated_at)
VALUES ('ali', 'ali@email.com', 'pass789', 'M', 'user', SYSDATE, SYSDATE);

INSERT INTO T_Users (username, email, password, gender, role, created_at, updated_at)
VALUES ('lina', 'admin@email.com', 'pass000', 'F', 'admin', SYSDATE, SYSDATE);

--------------------------------------------
-- T_MAGAZINES

INSERT INTO T_Magazines (user_id, magazine_title, magazine_category, magazine_price, publish_date, updated_at, magazine_img_url)
VALUES (18, 'Tech World', 'Technology', 15.99, TO_DATE('2024-03-01', 'YYYY-MM-DD'), SYSDATE, 'techworld.jpg');

INSERT INTO T_Magazines (user_id, magazine_title, magazine_category, magazine_price, publish_date, updated_at, magazine_img_url)
VALUES (15, 'Health Tips', 'Health', 10.50, TO_DATE('2024-02-15', 'YYYY-MM-DD'), SYSDATE, 'fashiontoday.jpg');

INSERT INTO T_Magazines (user_id, magazine_title, magazine_category, magazine_price, publish_date, updated_at, magazine_img_url)
VALUES (15, 'Travel Explorer', 'Travel', 20.00, TO_DATE('2024-01-20', 'YYYY-MM-DD'), SYSDATE, 'traveler.jpg');

INSERT INTO T_Magazines (user_id, magazine_title, magazine_category, magazine_price, publish_date, updated_at, magazine_img_url)
VALUES (7, 'Food Lover', 'Food', 12.75, TO_DATE('2024-03-10', 'YYYY-MM-DD'), SYSDATE, 'healthlife.jpg');

------------------------------------------
-- T_SUBSCRIPTIONS

INSERT INTO T_Subscriptions (user_id, magazine_id, start_date, subscribe_until)
VALUES (11, 35, TO_DATE('2024-04-01', 'YYYY-MM-DD'), TO_DATE('2025-04-01', 'YYYY-MM-DD'));

INSERT INTO T_Subscriptions (user_id, magazine_id, start_date, subscribe_until)
VALUES (12, 36, TO_DATE('2024-04-05', 'YYYY-MM-DD'), TO_DATE('2025-04-05', 'YYYY-MM-DD'));

INSERT INTO T_Subscriptions (user_id, magazine_id, start_date, subscribe_until)
VALUES (13, 37, TO_DATE('2024-04-10', 'YYYY-MM-DD'), TO_DATE('2025-04-10', 'YYYY-MM-DD'));

INSERT INTO T_Subscriptions (user_id, magazine_id, start_date, subscribe_until)
VALUES (14, 38, TO_DATE('2024-04-15', 'YYYY-MM-DD'), TO_DATE('2025-04-15', 'YYYY-MM-DD'));




--INSERT INTO T_Magazine_Interactions (user_id, magazine_id, feedback, rating)
--VALUES
--(1, 1, 'Great articles about tech trends!', '5'),
--(2, 2, 'Loved the fashion tips!', '4'),
--(3, 3, 'Very inspiring travel stories.', '5'),
--(4, 4, 'Helpful health advice.', '4');







-------------------- SEQUENCES -----------------------------

-- For T_Users
CREATE SEQUENCE SEQ_USERS
START WITH 1
INCREMENT BY 1
NOCACHE
NOCYCLE;

-- For T_Magazines
CREATE SEQUENCE SEQ_MAGAZINES
START WITH 1
INCREMENT BY 1
NOCACHE
NOCYCLE;

-- For T_Magazine_Interactions
CREATE SEQUENCE SEQ_MAG_INTERACTIONS
START WITH 1
INCREMENT BY 1
NOCACHE
NOCYCLE;

-- For T_Subscriptions
CREATE SEQUENCE SEQ_SUBSCRIPTIONS
START WITH 1
INCREMENT BY 1
NOCACHE
NOCYCLE;



-------------------- TRIGGERS -----------------------------


-- Trigger for T_Users
CREATE OR REPLACE TRIGGER trg_users_before_insert
BEFORE INSERT ON T_Users
FOR EACH ROW
BEGIN
    SELECT SEQ_USERS.NEXTVAL INTO :NEW.user_id FROM dual;
END;
/

-- Trigger for T_Magazines
CREATE OR REPLACE TRIGGER trg_magazines_before_insert
BEFORE INSERT ON T_Magazines
FOR EACH ROW
BEGIN
    SELECT SEQ_MAGAZINES.NEXTVAL INTO :NEW.magazine_id FROM dual;
END;
/

-- Trigger for T_Magazine_Interactions
CREATE OR REPLACE TRIGGER trg_mag_interact_b_ins
BEFORE INSERT ON T_Magazine_Interactions
FOR EACH ROW
BEGIN
    SELECT SEQ_MAG_INTERACTIONS.NEXTVAL INTO :NEW.interaction_id FROM dual;
END;
/

-- Trigger for T_Subscriptions
CREATE OR REPLACE TRIGGER trg_subscriptions_b_ins
BEFORE INSERT ON T_Subscriptions
FOR EACH ROW
BEGIN
    SELECT SEQ_SUBSCRIPTIONS.NEXTVAL INTO :NEW.subscription_id FROM dual;
END;
/




