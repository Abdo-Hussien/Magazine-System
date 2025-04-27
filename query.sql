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

