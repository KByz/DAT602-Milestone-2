DROP SCHEMA IF EXISTS dust2dust;
CREATE SCHEMA dust2dust;
USE dust2dust;

/*
   ____                _         ____        _        _                    
  / ___|_ __ ___  __ _| |_ ___  |  _ \  __ _| |_ __ _| |__   __ _ ___  ___ 
 | |   | '__/ _ \/ _` | __/ _ \ | | | |/ _` | __/ _` | '_ \ / _` / __|/ _ \
 | |___| | |  __/ (_| | ||  __/ | |_| | (_| | || (_| | |_) | (_| \__ \  __/
  \____|_|  \___|\__,_|\__\___| |____/ \__,_|\__\__,_|_.__/ \__,_|___/\___|
                                                                           
*/
DROP PROCEDURE IF EXISTS create_database;

DELIMITER $$

CREATE PROCEDURE create_database()
BEGIN
	DROP SCHEMA IF EXISTS dust2dust;
	CREATE SCHEMA dust2dust;
	/* DROP TABLE IF EXISTS `tile`;
	DROP TABLE IF EXISTS `inventory`;
	DROP TABLE IF EXISTS `item`;
	DROP TABLE IF EXISTS `npc`;
	DROP TABLE IF EXISTS `grid`;
	DROP TABLE IF EXISTS `map`;
	DROP TABLE IF EXISTS `game`;
	DROP TABLE IF EXISTS `character`;
	DROP TABLE IF EXISTS `user_account`; */

/*
 GAME, MAP, GRID
 A game of Dust2Dust comes into existance when at least one player enters a game. 
 From that point the game will be active and any other players will join the game on that ID. A single game can handle up to 10 players at once. 
 When a character attempts to join a game excessive of 10 players, a new game will be generated for that player to enter. 

 */

	CREATE TABLE `game`(
		`gameID` INT AUTO_INCREMENT PRIMARY KEY,
		`runtime` TIME DEFAULT 0,
		`status` VARCHAR(10) NOT NULL DEFAULT 'Active'
	);

	CREATE TABLE `map`(
		`mapID` INT AUTO_INCREMENT PRIMARY KEY,
		`gameID` INT,
		`maxRow` INT DEFAULT 10,
		`maxCol` INT DEFAULT 10,
		FOREIGN KEY (`gameID`) REFERENCES `game` (`gameID`)	
        ON DELETE CASCADE
	);

	/*
	 USER_ACCOUNT TABLE DROP AND CREATION
	 The purpose of the user_account table is to create and store accounts for player and admin-level users of the game. 
	 Each account is identified by a unique username (PK) and requires a unique email. 
	 The email, though a candidate key, cannot be used as the username will be public to other players and would be a breach of privacy. 
	 Only the user's first name is nessessary.
	 The account type distingusihes standard player from administrator level abilities in the system
	 
	 */

	CREATE TABLE `user_account`(
		`username` VARCHAR(50) PRIMARY KEY UNIQUE,
		`email` VARCHAR(255) UNIQUE,
		`password` VARCHAR(100),
		`firstName` VARCHAR(100),
		`accountType` VARCHAR(25) DEFAULT 'Player',
		`status` VARCHAR(25) DEFAULT 'Logged Out',
		`attempts` INT (3) DEFAULT 0
	);

	/*
	 CHARACTER TABLE DROP AND CREATION
	 The purpose of the character table is to store both static and dynamic data on a player character including
	 the character name (unique, PK), the player's username (FK), their base/current health during an active game, 
	 score during an active game, highest score earned, the status of the character (active or inactive), the id of the game they are active in,
	 the time of their last attack, application of an attack cooldown, 
	 a timer for their last movement, and an AFK check which will log them out of the game from the server side if inactive for too long

	 */

	CREATE TABLE `character`(
		`username` VARCHAR(50) PRIMARY KEY, 
		`gameID` INT NULL,
		`status` VARCHAR (10) DEFAULT 'Offline',
		`health` INT(4) DEFAULT 10,
		`currentScore` INT(10) DEFAULT 0,
		`highScore` INT(10) DEFAULT 0,
		`lastAttack` TIME DEFAULT 0,
		`attackCooldown` VARCHAR (10) DEFAULT 'OFF',
		`invincibility` VARCHAR (10) DEFAULT 'OFF',
		`lastMove` TIME DEFAULT 0,
		`afk` VARCHAR (10) DEFAULT 'OFF',
		FOREIGN KEY (`username`) REFERENCES `user_account` (`username`)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
		FOREIGN KEY (`gameID`) REFERENCES `game` (`gameID`)
		ON DELETE CASCADE
	);


	/* ITEM CREATE TABLE */

	CREATE TABLE `item`(
		`itemID` INT PRIMARY KEY,
		`itemName` VARCHAR(25),
		`description` TEXT,
		`damagePoints` INT(2) NULL,
		`healthPoints` INT(2) NULL
	);

	/* NPC CREATE TABLE */
	CREATE TABLE `npc`(
		`npcID` INT PRIMARY KEY, 
		`npcName` VARCHAR(100),
		`dialogue` TEXT,
		`itemID` INT NULL
	);

	/* TILE CREATE TABKE */

	CREATE TABLE `tile`(
		`tileID` INT AUTO_INCREMENT,
		`mapID` INT,
		`row` INT NOT NULL,
		`col` INT NOT NULL,
		`tileType` INT NOT NULL DEFAULT 0,
		`npcID` INT NULL,
		`itemID` INT NULL, 
		`username` VARCHAR(50) NULL,
		`movementTimer` TIME,
		PRIMARY KEY (`tileID`, `mapID`),
		FOREIGN KEY (`mapID`) REFERENCES `map` (`mapID`)
		ON DELETE CASCADE,
		FOREIGN KEY (`npcID`) REFERENCES `npc` (`npcID`),
		FOREIGN KEY (`itemID`) REFERENCES `item` (`itemID`),
		FOREIGN KEY (`username`) REFERENCES `character` (`username`)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);

	/* INVENTORY CREATE TABLE */

	CREATE TABLE `inventory`( 
		`username` VARCHAR(50),
		`itemID` INT, 
		`quantity` INT NULL,
		PRIMARY KEY (`username`, `itemID`),
		FOREIGN KEY (`username`) REFERENCES `character` (`username`)
		ON DELETE CASCADE,
		FOREIGN KEY (`itemID`) REFERENCES `item` (`itemID`)
	);
	COMMIT;
END $$

DELIMITER ;

-- CALL CREATE DATABASE PROCEDURE 
CALL create_database;

/*
  ___                     _     _____         _     ____        _        
 |_ _|_ __  ___  ___ _ __| |_  |_   _|__  ___| |_  |  _ \  __ _| |_ __ _ 
  | || '_ \/ __|/ _ \ '__| __|   | |/ _ \/ __| __| | | | |/ _` | __/ _` |
  | || | | \__ \  __/ |  | |_    | |  __/\__ \ |_  | |_| | (_| | || (_| |
 |___|_| |_|___/\___|_|   \__|   |_|\___||___/\__| |____/ \__,_|\__\__,_|
                                                                         
*/
USE dust2dust;

DROP PROCEDURE IF EXISTS insert_test_data;

DELIMITER $$

CREATE PROCEDURE insert_test_data()
COMMENT 'Inserting test data for dust2dust application testing'
BEGIN
	INSERT INTO user_account (`username`, `email`,`password`, `firstName`, `accountType`, `status`) VALUES ('test', 'test@email.com', 'test', 'test', 'Admin', 'Active');
    INSERT INTO user_account (`username`, `email`,`password`, `firstName`, `accountType`, `status`) VALUES ('KbyzFTW', 'kbyz@email.co.nz', 'CoolioJulio', 'Kira', 'Player', 'In-game');
	INSERT INTO user_account (`username`, `email`,`password`, `firstName`, `accountType`, `status`) VALUES ('DielgaChu', 'jbabs@email.co.nz', 'SwampStench', 'Julia', 'Player', 'Logged-out');
	INSERT INTO user_account (`username`, `email`,`password`, `firstName`, `accountType`, `status`) VALUES ('Fulmini', 'rossia@email.co.au', 'FKAGoth', 'Alex', 'Player', 'Logged-out');
	INSERT INTO user_account (`username`, `email`,`password`, `firstName`, `accountType`, `status`) VALUES ('Verga', 'generalmarx@email.com', 'CoconutTree', 'Mark', 'Player', 'Logged-out');
	INSERT INTO user_account (`username`, `email`,`password`, `firstName`, `accountType`, `status`) VALUES ('VintageSistah', 'jnel@email.co.nz', 'savblanc2019', 'Junel', 'Player', 'Logged-out');
	INSERT INTO user_account (`username`, `email`,`password`, `firstName`, `accountType`, `status`) VALUES ('KyrVorga', 'rhydawg@email.co.nz', 'somethingHard1', 'Rhylei', 'Player', 'Logged-out');

	/* INSERT GAME */
	INSERT INTO `game` (gameID, runtime, status) VALUES (1, '00:00:00', 'Active');

	/*INSERT NPC DATA*/
	INSERT INTO `npc` (`npcID`, `npcName`, `dialogue`, `itemID`) VALUES (1, 'Clyde Barrow', 'Hey partner! Im on the run and these bullets are weighing me down! Here, take some!', 1);
	INSERT INTO `npc` (`npcID`, `npcName`, `dialogue`) VALUES (2, 'Wyatt Earp', 'I got my eye on you, cowpoke.');

	/* INSERT ITEM DATA*/
	INSERT INTO `item` (`itemID`, `itemName`, `description`, `damagePoints`) VALUES (1, 'Bullet', 'Put this in your revolver, point, and shoot.', 1);
	INSERT INTO `item` (`itemID`, `itemName`, `description`, `healthPoints`) VALUES (2, 'Whiskey', 'Drink this for your vitality.', 2);


	/* INSERT PLAYER CHARACTER DATA
	 Displays two player characters at different states, offline with only relevant data, and online with current in-game data.
	  */
	INSERT INTO `character` (`username`, `gameID`) VALUES ('test', 1);


	/*INSERT INVENTORY DATA*/
	INSERT INTO `inventory` (`username`, `itemID`, `quantity`) VALUES ('test', 1, 3);
	INSERT INTO `inventory` (`username`, `itemID`, `quantity`) VALUES ('test', 2, 0);
	
	COMMIT;
    
END $$
DELIMITER ;

-- CALL INSERT TEST DATA PROCEDURE
CALL insert_test_data;

/*
  _                _          ___     _               _               _   
 | |    ___   __ _(_)_ __    ( _ )   | |    ___   ___| | _____  _   _| |_ 
 | |   / _ \ / _` | | '_ \   / _ \/\ | |   / _ \ / __| |/ / _ \| | | | __|
 | |__| (_) | (_| | | | | | | (_>  < | |__| (_) | (__|   < (_) | |_| | |_ 
 |_____\___/ \__, |_|_| |_|  \___/\/ |_____\___/ \___|_|\_\___/ \__,_|\__|
             |___/                                                        
*/
DROP PROCEDURE IF EXISTS login;

DELIMITER $$

CREATE PROCEDURE login(IN `username_para` VARCHAR(50), IN `password_para` VARCHAR(100))
COMMENT 'Check login'
BEGIN
    DECLARE `status` VARCHAR(10) DEFAULT 'Logged out';
    DECLARE `attempts` INT DEFAULT 0;

    SELECT ua.`status`, ua.`attempts`
    INTO `status`, `attempts`
    FROM `user_account` ua
    WHERE ua.`username` = `username_para`;

    IF `status` = 'Locked' THEN
        SELECT 'Account Locked' AS MESSAGE;
    ELSEIF EXISTS (
        SELECT 1
        FROM `user_account` ua
        WHERE ua.`username` = `username_para`
        AND ua.`password` = `password_para`
    ) THEN
        UPDATE `user_account` ua
        SET ua.`status` = 'Online',
            ua.`attempts` = 0
        WHERE ua.`username` = `username_para`;
        SELECT 'Logged In' AS MESSAGE;
    ELSE
        UPDATE `user_account` ua
        SET ua.`attempts` = ua.`attempts` + 1
        WHERE ua.`username` = `username_para`;

        SELECT ua.`attempts`
        INTO `attempts`
        FROM `user_account` ua
        WHERE ua.`username` = `username_para`;

        IF `attempts` >= 3 THEN
            UPDATE `user_account` ua
            SET ua.`status` = 'Locked'
            WHERE ua.`username` = `username_para`;
            SELECT 'Invalid Login: Account Locked' AS MESSAGE;
        ELSE
            SELECT 'Invalid Login' AS MESSAGE;
        END IF;
    END IF;
COMMIT;

END $$

DELIMITER ;

-- TEST SUCCESSFUL LOGIN PROCEDURE
-- Set account status to offline to allow login
UPDATE `user_account`
	SET `status` = 'Logged out'
    WHERE `username` = 'KbyzFTW';
    
-- Set login attempts to default    
UPDATE `user_account`
	SET `attempts` = 0
    WHERE `username` = 'KbyzFTW';

-- Check user account
SELECT * FROM `user_account`
WHERE `username` = 'KbyzFTW';
    
-- Call successful login
CALL login ('KbyzFTW', 'CoolioJulio');

-- TEST FAILED LOGIN PROCEDURE AND LOCKOUT
-- Log character out
UPDATE `user_account`
	SET `status` = 'Logged out'
    WHERE `username` = 'KbyzFTW';
    
-- Set login attempts to default    
UPDATE `user_account`
	SET `attempts` = 0
    WHERE `username` = 'KbyzFTW';
    
-- Call invalid login credentials x3
CALL login ('KbyzFTW', 'akdandk');

-- Check user account
SELECT * FROM `user_account`
WHERE `username` = 'KbyzFTW';

/*
  _                            _   
 | |    ___   __ _  ___  _   _| |_ 
 | |   / _ \ / _` |/ _ \| | | | __|
 | |__| (_) | (_| | (_) | |_| | |_ 
 |_____\___/ \__, |\___/ \__,_|\__|
             |___/                 
*/
DROP PROCEDURE IF EXISTS logout;

DELIMITER $$
CREATE PROCEDURE logout(IN `username_para` VARCHAR (50))
BEGIN
	DECLARE `status` VARCHAR (10);
    
	SELECT ua.`status`
    INTO `status`
    FROM `user_account` ua
    WHERE ua.`username` = `username_para`;
    
    SELECT ua.`status` FROM `user_account` ua
    WHERE ua.`username` = `username_para`;
	IF `status` = 'Logged out' THEN
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT  = "Error: That account is already logged out.";
	END IF;
    
	UPDATE `user_account` ua
	SET ua.`status` = 'Logged out'
	WHERE ua.`username` = `username_para`;
    SELECT 'Logged Out' AS MESSAGE;
    
COMMIT;
END $$

DELIMITER ;

-- TEST LOGOUT PROCEDURE

-- Login a user
CALL login ('test', 'test');

-- Check user status
SELECT * FROM `user_account` WHERE `username` = 'test';

-- Logout user
CALL logout ('test');

/*
  ____            _     _                 _                             _   
 |  _ \ ___  __ _(_)___| |_ ___ _ __     / \   ___ ___ ___  _   _ _ __ | |_ 
 | |_) / _ \/ _` | / __| __/ _ \ '__|   / _ \ / __/ __/ _ \| | | | '_ \| __|
 |  _ <  __/ (_| | \__ \ ||  __/ |     / ___ \ (_| (_| (_) | |_| | | | | |_ 
 |_| \_\___|\__, |_|___/\__\___|_|    /_/   \_\___\___\___/ \__,_|_| |_|\__|
            |___/                                                           
*/
DROP PROCEDURE IF EXISTS signup;

DELIMITER $$

CREATE PROCEDURE signup (IN `username_para` VARCHAR(50), IN `email_para` VARCHAR(255), IN `password_para` VARCHAR(100), IN `firstName_para` VARCHAR (100))
BEGIN
	DECLARE var_exists INT;
-- Check existing usernames in user account table
	SELECT COUNT(*) INTO var_exists
	FROM user_account
	WHERE `username` = `username_para`;
	IF var_exists > 0 THEN
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'That username is taken! Try something different.';
	END IF;
-- Check existing email in user account table
	SELECT COUNT(*) INTO var_exists
	FROM user_account
	WHERE `email` = `email_para`;
	IF var_exists > 0 THEN
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'That email address is already in use! Try something different.';
	END IF;
-- Reject null criteria
	IF (`username_para` IS NULL OR `username_para` = '') 
		OR (`email_para` IS NULL OR `email_para` = '') 
		OR (`password_para` IS NULL OR `password_para` = '')  
        OR (`firstName_para` IS NULL OR `firstName_para` = '') THEN
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Error: Some fields are null!';
	END IF;

-- Insert new user if critera is acceptable 
	INSERT INTO user_account (`username`, `email`, `password`, `firstName`) VALUES (`username_para`, `email_para`, `password_para`, `firstName_para`);
	SELECT 'Account created!' AS MESSAGE;
    
COMMIT;

END $$

DELIMITER ;

-- TEST REGISTER ACCOUNT PROCEDURE
CALL signup ('xXBlack_BloodzXx', 'whitefang@email.co.uk', 'fangz', 'Kyle');

-- Check user account table for new account
SELECT * FROM `user_account` WHERE `username` = 'xXBlack_BloodzXx';

/*
  _____    _ _ _        _                             _   
 | ____|__| (_) |_     / \   ___ ___ ___  _   _ _ __ | |_ 
 |  _| / _` | | __|   / _ \ / __/ __/ _ \| | | | '_ \| __|
 | |__| (_| | | |_   / ___ \ (_| (_| (_) | |_| | | | | |_ 
 |_____\__,_|_|\__| /_/   \_\___\___\___/ \__,_|_| |_|\__|
                                                          
*/
DROP PROCEDURE IF EXISTS edit_account;

DELIMITER $$

CREATE PROCEDURE edit_account (IN `username_para` VARCHAR(50), IN `new_username_para` VARCHAR (50), IN `new_email_para` VARCHAR(255), IN `new_password_para` VARCHAR(100), IN `new_firstName_para` VARCHAR (100))
BEGIN
	DECLARE var_exists INT;
-- Check existing usernames in user account table
	SELECT COUNT(*) INTO var_exists
	FROM user_account
	WHERE `username` = `new_username_para`;
	IF var_exists > 0 THEN
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Error: That username is taken! Try something different.';
	END IF;
-- Check existing email in user account table
	SELECT COUNT(*) INTO var_exists
	FROM user_account
	WHERE `email` = `new_email_para`;
	IF var_exists > 0 THEN
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Error: That email address is already in use! Try something different.';
	END IF;
-- Reject null criteria
	IF (`username_para` IS NULL OR `username_para` = '') 
		OR (`new_username_para` IS NULL OR `new_username_para` = '') 
        OR (`new_email_para` IS NULL OR `new_email_para` = '') 
        OR (`new_password_para` IS NULL OR `new_password_para` = '')  
        OR (`new_firstName_para` IS NULL OR `new_firstName_para` = '') THEN
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Error: Some fields are null!';
	END IF;

-- Insert new user if critera is acceptable 
	UPDATE `user_account` 
    SET 
		`username` = `new_username_para`,
        `email` = `new_email_para`,
        `password` = `new_password_para`,
        `firstName` = `new_firstName_para`
    WHERE `username` = `username_para`;
	SELECT 'Account updated!' AS MESSAGE;

COMMIT;

END $$

DELIMITER ;

-- TES EDIT ACCOUNT PROCEDURE

SELECT * FROM `user_account` WHERE `username` = 'KyrVorga';

-- Select existing username, provide new credentials (username, email, password, and first name)
CALL edit_account ('TyrMorgen', 'TyrrMorgen', 'onehandd@email.com', 'Justice', 'Tyr');

-- See updated accounts
SELECT * FROM `user_account`;

/*
  ____                 _    _ _      _                             _       
 / ___|  ___  ___     / \  | | |    / \   ___ ___ ___  _   _ _ __ | |_ ___ 
 \___ \ / _ \/ _ \   / _ \ | | |   / _ \ / __/ __/ _ \| | | | '_ \| __/ __|
  ___) |  __/  __/  / ___ \| | |  / ___ \ (_| (_| (_) | |_| | | | | |_\__ \
 |____/ \___|\___| /_/   \_\_|_| /_/   \_\___\___\___/ \__,_|_| |_|\__|___/
                                                                           
*/
DROP PROCEDURE IF EXISTS all_accounts;

DELIMITER $$

CREATE PROCEDURE all_accounts()
BEGIN
	SELECT * 
    FROM user_account;
    
COMMIT;

END $$

DELIMITER ;

-- TEST SEE ALL ACCOUNTS PROCEDURE
CALL all_accounts;

/*
  ____                   _                             _   
 | __ )  __ _ _ __      / \   ___ ___ ___  _   _ _ __ | |_ 
 |  _ \ / _` | '_ \    / _ \ / __/ __/ _ \| | | | '_ \| __|
 | |_) | (_| | | | |  / ___ \ (_| (_| (_) | |_| | | | | |_ 
 |____/ \__,_|_| |_| /_/   \_\___\___\___/ \__,_|_| |_|\__|
                                                           
*/

DROP PROCEDURE IF EXISTS ban_account;

DELIMITER $$

CREATE PROCEDURE ban_account (IN `username_para` VARCHAR(50))
COMMENT 'Lock player account.'
BEGIN
	-- Update the status field to  'Locked' preventing any form of login attempt
	UPDATE user_account ua
	SET ua.status = 'Locked'
	WHERE ua.username = `username_para`;
    
    SELECT 'Account banned!' AS MESSAGE_TEXT;
    
COMMIT;

END $$

DELIMITER ;

-- TEST BAN ACCOUNT PROCEDURE

-- Set status to an unbanned state
CALL logout ('test');

 -- Call procedure to set an account to a locked state (banned) an account by username
CALL ban_account ('test');
 
 -- View updated account status
SELECT `username`, `status`
FROM `user_account`
WHERE `username` = 'test';

/*
  _   _       _                      _                             _   
 | | | |_ __ | |__   __ _ _ __      / \   ___ ___ ___  _   _ _ __ | |_ 
 | | | | '_ \| '_ \ / _` | '_ \    / _ \ / __/ __/ _ \| | | | '_ \| __|
 | |_| | | | | |_) | (_| | | | |  / ___ \ (_| (_| (_) | |_| | | | | |_ 
  \___/|_| |_|_.__/ \__,_|_| |_| /_/   \_\___\___\___/ \__,_|_| |_|\__|
                                                                       
*/
DROP PROCEDURE IF EXISTS unban_account;

DELIMITER $$

CREATE PROCEDURE unban_account(IN `username_para` VARCHAR (50))
BEGIN
	-- Update account status to 'Logged out' to allow login attempts
	UPDATE `user_account`
    SET `status` = 'Logged Out', `attempts` = 0
    WHERE `username` = `username_para`;
    
    SELECT 'Account unbanned!' AS MESSAGE_TEXT;
COMMIT;

END $$

DELIMITER ;

-- TEST UNBAN ACCOUNT PROCEDURE

-- Bann an account
CALL ban_account ('test');

-- View update
SELECT * FROM `user_account` WHERE `username` = 'test';

-- Unban the account
CALL unban_account ('test');

/*
  ____       _      _            _                             _   
 |  _ \  ___| | ___| |_ ___     / \   ___ ___ ___  _   _ _ __ | |_ 
 | | | |/ _ \ |/ _ \ __/ _ \   / _ \ / __/ __/ _ \| | | | '_ \| __|
 | |_| |  __/ |  __/ ||  __/  / ___ \ (_| (_| (_) | |_| | | | | |_ 
 |____/ \___|_|\___|\__\___| /_/   \_\___\___\___/ \__,_|_| |_|\__|
                                                                   
*/
DROP PROCEDURE IF EXISTS delete_account;

DELIMITER $$

CREATE PROCEDURE delete_account(IN `username_para` VARCHAR(50))
COMMENT 'Delete user account.'

BEGIN

	DELETE
	FROM user_account ua 
	WHERE ua.username = `username_para`;
    
    SELECT 'Account deleted!' AS MESSAGE_TEXT;

COMMIT;

END $$

DELIMITER ; 

-- TEST DELETE ACCOUNT PROCEUDRE 

-- Insert new player
CALL signup ('Paquod', 'whaleoil@email.com', 'MobyDick', 'Ahab');

-- Delete the account
CALL delete_account ('Paquod');

-- Check user account list
SELECT * FROM `user_account`;

/*
  ____                 _                 _            _____ _ _        _____                      
 |  _ \ __ _ _ __   __| | ___  _ __ ___ (_)___  ___  |_   _(_) | ___  |_   _|   _ _ __   ___  ___ 
 | |_) / _` | '_ \ / _` |/ _ \| '_ ` _ \| / __|/ _ \   | | | | |/ _ \   | || | | | '_ \ / _ \/ __|
 |  _ < (_| | | | | (_| | (_) | | | | | | \__ \  __/   | | | | |  __/   | || |_| | |_) |  __/\__ \
 |_| \_\__,_|_| |_|\__,_|\___/|_| |_| |_|_|___/\___|   |_| |_|_|\___|   |_| \__, | .__/ \___||___/
                                                                            |___/|_|              
*/
DROP FUNCTION IF EXISTS get_tile_type;

DELIMITER $$

CREATE FUNCTION get_tile_type() RETURNS INT
COMMENT 'Function to generate different tile types when called in the draw_gameboard procedure'
DETERMINISTIC 
BEGIN
	-- Create tileType 1 to represent an item on a tile
	IF ROUND(RAND() * 3) = 2 THEN
		RETURN 1;
	-- Create tileType 2 to represent an NPC on a tile
	ELSEIF ROUND(RAND() * 2) = 1 THEN
		RETURN 2;
	ELSE
    -- Create tileType 0 to represent an empty tile
		RETURN 0;
	END IF;	

END $$

DELIMITER ;

/*
   ____                _         _   _                  ____                      
  / ___|_ __ ___  __ _| |_ ___  | \ | | _____      __  / ___| __ _ _ __ ___   ___ 
 | |   | '__/ _ \/ _` | __/ _ \ |  \| |/ _ \ \ /\ / / | |  _ / _` | '_ ` _ \ / _ \
 | |___| | |  __/ (_| | ||  __/ | |\  |  __/\ V  V /  | |_| | (_| | | | | | |  __/
  \____|_|  \___|\__,_|\__\___| |_| \_|\___| \_/\_/    \____|\__,_|_| |_| |_|\___|
                                                                                  
*/
DROP PROCEDURE IF EXISTS draw_gameboard;

DELIMITER $$

CREATE PROCEDURE draw_gameboard(IN `maxRow_para` INT, IN `maxCol_para` INT)
BEGIN
	DECLARE new_game_id INT;
	DECLARE new_map_id INT;
	DECLARE current_row INT DEFAULT 0;
	DECLARE current_col INT DEFAULT 0;
	DECLARE tile_type INT DEFAULT 0;

-- Create a new gameID based on the next numerical order from the last insterted gameID
INSERT INTO `game` (`status`) VALUES ('Active');
SET new_game_id = LAST_INSERT_ID();

-- Create a new mapID based on the next numerical order from the last insterted mapID and related to the last inserted gameID (above)
INSERT INTO `map` (`gameID`) VALUES (new_game_id);
SET new_map_id = LAST_INSERT_ID();
-- Create maxium rows and columns that end at a given border, set the tile type with the tile type function to place an item (1) or npc (2) at random
	WHILE current_row < `maxRow_para` DO
		WHILE current_col < `maxCol_para` DO
			SET tile_type = get_tile_type();
		
			 -- Insert an id for each row and column which will identify the tile one by one until the parameter is reached
				INSERT INTO `tile` (`mapID`, `row`, `col`, `tileType`)
				VALUES (new_map_id, current_row, current_col, tile_type);
			
			SET current_col = current_col + 1;
		END WHILE;
        
		SET current_col = 0;
		SET current_row = current_row + 1;
        
	END WHILE;
    
	SELECT 'New gameboard created!' AS MESSAGE;
    
COMMIT;

END $$

DELIMITER ;

-- TEST GAMEBOARD PROCEDURE
CALL draw_gameboard(10,10);

-- View the new game created
SELECT * FROM `game`;
-- View the new map created
SELECT * FROM `map`;
-- Ensure there is a correct number of tiles
SELECT COUNT(*) FROM `tile` WHERE `mapID` = 2;
-- View information for all tiles
SELECT * FROM `tile` WHERE `mapID` = 3;

/*
     _       _     _                              _                          _            
    / \   __| | __| |  _ __   _____      __   ___| |__   __ _ _ __ __ _  ___| |_ ___ _ __ 
   / _ \ / _` |/ _` | | '_ \ / _ \ \ /\ / /  / __| '_ \ / _` | '__/ _` |/ __| __/ _ \ '__|
  / ___ \ (_| | (_| | | | | |  __/\ V  V /  | (__| | | | (_| | | | (_| | (__| ||  __/ |   
 /_/   \_\__,_|\__,_| |_| |_|\___| \_/\_/    \___|_| |_|\__,_|_|  \__,_|\___|\__\___|_|   
                                                                                          
*/
DROP PROCEDURE IF EXISTS new_character;

DELIMITER $$

CREATE PROCEDURE new_character (IN `username_para` VARCHAR (50))
COMMENT 'Enter a new player character into the character table'
BEGIN

DECLARE no_user INT;
DECLARE character_exists INT;
-- Check if username does not exists in the user_account table, violating the foreign key constraint
	SELECT COUNT(*) INTO no_user
		FROM `user_account`
		WHERE `username` = `username_para`;
		IF no_user <= 0 THEN
			SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Error: That username does not exist! Sign up for an account first!';
        
-- Check to see if character exists within the character table
		END IF;
	SELECT COUNT(*) INTO character_exists
		FROM `character` 
		WHERE `username` = `username_para`;
	-- If character exists, call error handler to prevent an insert     
		IF character_exists > 0 THEN
			SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Error: That character already exists!';
	-- If character does not exists, create a new character with the given parameter
	ELSE    
		INSERT INTO `character` (`username`)
		VALUES (`username_para`);

    
		SELECT 'Character created!' AS MESSAGE_TEXT;
	END IF;
COMMIT;

END$$

DELIMITER ;

-- TEST NEW CHARACTER PROCEDURE
-- Test error for existing character
CALL new_character ('test');

-- Test error for no existing username
CALL new_character ('kjasnd');

-- Test successful call
CALL new_character ('KbyzFTW');

-- See new character
SELECT * FROM `character`;

/*
  _____       _                 _       ____                      
 | ____|_ __ | |_ ___ _ __     / \     / ___| __ _ _ __ ___   ___ 
 |  _| | '_ \| __/ _ \ '__|   / _ \   | |  _ / _` | '_ ` _ \ / _ \
 | |___| | | | ||  __/ |     / ___ \  | |_| | (_| | | | | | |  __/
 |_____|_| |_|\__\___|_|    /_/   \_\  \____|\__,_|_| |_| |_|\___|
                                                                  
*/
DROP PROCEDURE IF EXISTS enter_character;

DELIMITER $$

CREATE PROCEDURE enter_character (IN `username_para` VARCHAR(50), `gameID_para` INT)
BEGIN
	DECLARE home_tile INT;
    DECLARE character_exists INT;
    
	-- Select an unoccupied tile as the hometile
    SELECT `tileID`
		INTO home_tile
	FROM `tile`
		WHERE `tileType` = 0
        ORDER BY RAND()
        LIMIT 1;
-- Check to see if the player already has a character in the database
    SELECT COUNT(*) INTO character_exists
    FROM `character` 
    WHERE `username` = `username_para`;
    
    -- If the character exists, update stat columns to defaults
    IF character_exists > 0 THEN
    UPDATE `character` 
    SET  `gameID` = `gameID_para`,
		`status` = 'Active',
		`health` = 10,
		`currentScore` = 0,
		`attackCooldown` = 'Off',
		`invincibility` = 'Off',
		`lastMove` = NOW()
	WHERE `username` = `username_para`;
    ELSE 
    -- Insert new character details with the given username parameter, setting all stat columns to defaults
		INSERT INTO `character` (`username`, `gameID`, `status`, `health`, `currentScore`, `attackCooldown`, `invincibility`, `lastMove`)
		VALUES (`username_para`, `gameID_para`, 'Active', 10, 0, 'Off', 'Off', NOW());
	END IF;
    
	SET autocommit = OFF;
	START TRANSACTION;
    IF EXISTS (
		SELECT  ua.`username` 
		FROM `user_account` ua
		WHERE ua.`username` = `username_para`
        )
	THEN
		UPDATE `tile` 
        SET `username` = `username_para`
        WHERE `tileID` = home_tile;
        
		UPDATE `user_account` ua
		SET ua.`status` = 'Active'
		WHERE ua.`username` = `username_para`;
        
		COMMIT;
	ELSE 
		ROLLBACK;
	END IF;
    
END $$

DELIMITER ;

-- TEST ENTER GAME PROCEDURE

-- Create a new game
CALL draw_gameboard (9,9);

-- Select the map associated with the new game created
SELECT * FROM `map`;

-- Call procedure with a new character
CALL enter_character ('Verga', 4);

-- See the character on the map
SELECT * FROM `tile` WHERE `username` = 'Verga';


/*
  _   _           _       _         _           _                              
 | | | |_ __   __| | __ _| |_ ___  | | __ _ ___| |_   _ __ ___   _____   _____ 
 | | | | '_ \ / _` |/ _` | __/ _ \ | |/ _` / __| __| | '_ ` _ \ / _ \ \ / / _ \
 | |_| | |_) | (_| | (_| | ||  __/ | | (_| \__ \ |_  | | | | | | (_) \ V /  __/
  \___/| .__/ \__,_|\__,_|\__\___| |_|\__,_|___/\__| |_| |_| |_|\___/ \_/ \___|
       |_|                                                                     
*/
DROP PROCEDURE IF EXISTS update_lastMove;

DELIMITER $$

CREATE PROCEDURE update_lastMove (IN `username_para` VARCHAR(50))
COMMENT 'Updates the players lastMove column when an action is made. To be called recursively in movement-based procedures'
BEGIN
	UPDATE `character`
		SET `lastMove` = NOW()
		WHERE `username` = `username_para`;
COMMIT;

END $$

DELIMITER ;

/*
  ____  _                         __  __                                     _   
 |  _ \| | __ _ _   _  ___ _ __  |  \/  | _____   _____ _ __ ___   ___ _ __ | |_ 
 | |_) | |/ _` | | | |/ _ \ '__| | |\/| |/ _ \ \ / / _ \ '_ ` _ \ / _ \ '_ \| __|
 |  __/| | (_| | |_| |  __/ |    | |  | | (_) \ V /  __/ | | | | |  __/ | | | |_ 
 |_|   |_|\__,_|\__, |\___|_|    |_|  |_|\___/ \_/ \___|_| |_| |_|\___|_| |_|\__|
                |___/                                                            
*/
DROP PROCEDURE IF EXISTS player_movement;

DELIMITER $$

CREATE PROCEDURE player_movement(IN `username_para` VARCHAR(50), IN `direction` VARCHAR(10), IN `mapID_para` INT)
BEGIN
    DECLARE current_row INT;
    DECLARE current_col INT;
    DECLARE new_row INT;
    DECLARE new_col INT;

    -- Find the player's current tile
    SELECT `row`, `col` INTO current_row, current_col
    FROM `tile`
    WHERE `username` = `username_para`
    AND `mapID` = `mapID_para`;

    -- Determine the new row and column based on the direction
    CASE `direction`
        WHEN 'up' THEN
            SET new_row = current_row - 1;
            SET new_col = current_col;
        WHEN 'down' THEN
            SET new_row = current_row + 1;
            SET new_col = current_col;
        WHEN 'left' THEN
            SET new_row = current_row;
            SET new_col = current_col - 1;
        WHEN 'right' THEN
            SET new_row = current_row;
            SET new_col = current_col + 1;
        ELSE
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Cant move that way!';
    END CASE;

    -- Check if the target tile is no occupied by another player
    IF EXISTS (SELECT 1 FROM `tile` WHERE `row` = new_row AND `col` = new_col AND `username` IS NOT NULL AND `username` != `username_para`) THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'That tile is occupied!';
    END IF;
    
    
    -- Update the player's current tile and the target tile
    UPDATE `tile`
    SET `username` = NULL, `tileType` = 0
    WHERE `row` = current_row 
    AND `col` = current_col 
    AND `username` = `username_para`
    AND `mapID` = `mapID_para`;
    
	-- Update the username of the occupied tile to the current player
    UPDATE `tile`
    SET `username` = `username_para`
    WHERE `row` = new_row AND `col` = new_col
    AND `mapID` = `mapID_para`;
    
    CALL update_lastMove (`username_para`);
COMMIT;

END $$

DELIMITER ;

-- TEST PLAYER MOVEMENT PROCEDURE
-- Select the tile where a username exists. Take note of the tileID they are on.

SELECT * FROM `tile` WHERE `username` = 'test';

-- Call the movement procedure, make sure the mapID is correct
CALL player_movement ('test', 'left', 1);

-- See where the character is in the map
SELECT * FROM `tile` WHERE `username` = 'test';


/*
  _   _ ____   ____   __  __                                     _   
 | \ | |  _ \ / ___| |  \/  | _____   _____ _ __ ___   ___ _ __ | |_ 
 |  \| | |_) | |     | |\/| |/ _ \ \ / / _ \ '_ ` _ \ / _ \ '_ \| __|
 | |\  |  __/| |___  | |  | | (_) \ V /  __/ | | | | |  __/ | | | |_ 
 |_| \_|_|    \____| |_|  |_|\___/ \_/ \___|_| |_| |_|\___|_| |_|\__|
                                                                     
*/
-- INCOMPLETE 
/*
  ____  _                  _ _                                     _   _ _           
 |  _ \| | __ _  ___ ___  (_) |_ ___ _ __ ___  ___    ___  _ __   | |_(_) | ___  ___ 
 | |_) | |/ _` |/ __/ _ \ | | __/ _ \ '_ ` _ \/ __|  / _ \| '_ \  | __| | |/ _ \/ __|
 |  __/| | (_| | (_|  __/ | | ||  __/ | | | | \__ \ | (_) | | | | | |_| | |  __/\__ \
 |_|   |_|\__,_|\___\___| |_|\__\___|_| |_| |_|___/  \___/|_| |_|  \__|_|_|\___||___/
                                                                                     
-- INCOMPLETE 

DROP FUNCTION IF EXISTS place_item;

DELIMITER $$

CREATE PROCEDURE place_items()
BEGIN
    UPDATE `tile` t
    JOIN `item` i ON t.`itemID` = i.`itemID`
    SET t.`itemID` = i.`itemID`
    WHERE t.`tileType` = 1;
END $$

DELIMITER ;

*/
/*
  ____                       ____       _       _       
 / ___|  ___ ___  _ __ ___  |  _ \ ___ (_)_ __ | |_ ___ 
 \___ \ / __/ _ \| '__/ _ \ | |_) / _ \| | '_ \| __/ __|
  ___) | (_| (_) | | |  __/ |  __/ (_) | | | | | |_\__ \
 |____/ \___\___/|_|  \___| |_|   \___/|_|_| |_|\__|___/
                                                        
*/
DROP PROCEDURE IF EXISTS score_points;

DELIMITER $$

CREATE PROCEDURE score_points (IN `username_para` VARCHAR (50))
COMMENT 'Add 100 to the interger in the currentScore field in the character table'
BEGIN
	UPDATE `character`
    SET `currentScore` = `currentScore` + 100
    WHERE `username` = `username_para`;
    
COMMIT;

END $$

DELIMITER ;

-- TEST SCORE POINTS
CALL score_points ('test');

-- See updated currentScore column in the character table
SELECT `username`, `currentScore`
FROM `character` 
WHERE `username` = 'test';

/*
  ____                 _    _ _      _        _   _              ____                           
 / ___|  ___  ___     / \  | | |    / \   ___| |_(_)_   _____   / ___| __ _ _ __ ___   ___  ___ 
 \___ \ / _ \/ _ \   / _ \ | | |   / _ \ / __| __| \ \ / / _ \ | |  _ / _` | '_ ` _ \ / _ \/ __|
  ___) |  __/  __/  / ___ \| | |  / ___ \ (__| |_| |\ V /  __/ | |_| | (_| | | | | | |  __/\__ \
 |____/ \___|\___| /_/   \_\_|_| /_/   \_\___|\__|_| \_/ \___|  \____|\__,_|_| |_| |_|\___||___/
                                                                                                
*/
DROP PROCEDURE IF EXISTS get_game_and_players;

DELIMITER $$

CREATE PROCEDURE get_game_and_players()
COMMENT 'Return all active games with associated active players.'
BEGIN
	SELECT g.gameID, c.username
	FROM game g
		INNER JOIN `character` c 
		ON g.gameID = c.gameID
		AND c.gameID IS NOT NULL
		AND g.status = 'Active';
        
COMMIT;

END $$

DELIMITER ;

-- TEST GAMES AND PLAYERS CALL
SELECT * FROM `game`;
CALL get_game_and_players;


/*
  ____                                 ____  _                         _____                       ____                      
 |  _ \ ___ _ __ ___   _____   _____  |  _ \| | __ _ _   _  ___ _ __  |  ___| __ ___  _ __ ___    / ___| __ _ _ __ ___   ___ 
 | |_) / _ \ '_ ` _ \ / _ \ \ / / _ \ | |_) | |/ _` | | | |/ _ \ '__| | |_ | '__/ _ \| '_ ` _ \  | |  _ / _` | '_ ` _ \ / _ \
 |  _ <  __/ | | | | | (_) \ V /  __/ |  __/| | (_| | |_| |  __/ |    |  _|| | | (_) | | | | | | | |_| | (_| | | | | | |  __/
 |_| \_\___|_| |_| |_|\___/ \_/ \___| |_|   |_|\__,_|\__, |\___|_|    |_|  |_|  \___/|_| |_| |_|  \____|\__,_|_| |_| |_|\___|
                                                     |___/                                                                   
*/
DROP PROCEDURE IF EXISTS remove_player;

DELIMITER $$

CREATE PROCEDURE remove_player(IN `username_para` VARCHAR (50))
COMMENT 'Removes an active player from an active game at an admin level'
BEGIN

	IF
    (`username_para` = NULL OR `username_para` = '') THEN
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Error: Fields were null!';
	END IF;
    
    UPDATE `tile`
    SET `username` = NULL
    WHERE `username` = `username_para`;
    
	UPDATE `character`
    SET `gameID` = NULL, `status` = 'Offline'
    WHERE `gameID` IS NOT NULL
    AND `username` = `username_para`;
    
    UPDATE `user_account`
    SET `status` = 'Logged-in'
    WHERE `username` = `username_para`;
	
    SELECT 'Player removed!' AS MESSAGE;
    
COMMIT;

END $$

DELIMITER ;

-- TEST REMOVE PLAYER FROM GAME PROCEDURE
-- Reutrn an active game and list of active players
CALL get_game_and_players;

-- Remove an active player
CALL remove_player('test');



/*
  _  ___ _ _    ____                      
 | |/ (_) | |  / ___| __ _ _ __ ___   ___ 
 | ' /| | | | | |  _ / _` | '_ ` _ \ / _ \
 | . \| | | | | |_| | (_| | | | | | |  __/
 |_|\_\_|_|_|  \____|\__,_|_| |_| |_|\___|
                                          
*/
DROP PROCEDURE IF EXISTS kill_game;

DELIMITER $$

CREATE PROCEDURE kill_game (IN `gameID_para` INT)
BEGIN
	-- Deleting the gameID from the associated mapID
	DELETE FROM `map`
	WHERE `gameID` = `gameID_para`;
	
    -- Update the status of the game to 'offline' to prevent any active players from joining
    UPDATE `game`
    SET `status` = 'Offline'
    WHERE `gameID` = `gameID_para`;
    
    -- Update all associated characters in that game to disassociate them with the gameID and set their status to 'Logged in'
    UPDATE `character` c
    JOIN `game` g
		ON c.`gameID` = g.`gameID`
    SET c.`status` = 'Logged in', c.`gameID` = NULL
    WHERE g.`status` = 'Offline'
    AND g.`gameID` = `gameID_para`;

	SELECT 'Game killed!' AS MESSAGE_TEXT;

COMMIT;

END $$

DELIMITER ;

-- TEST KILL GAME PROCEDURE

-- Create a game
CALL draw_gameboard(9,9);
-- Insert a character
CALL enter_character ('test', 3);
-- Kill the game with the new gameID 
CALL kill_game (3);

-- See updates to the game
SELECT * FROM `game`;
-- See updates to the character
SELECT * FROM `character` WHERE `username` = 'test';




