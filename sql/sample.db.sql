
CREATE TABLE IF NOT EXISTS `Store_Information` (
	`store_name`	TEXT,
	`Sales`	INTEGER,
	`Date`	TEXT
);
INSERT INTO `Store_Information` VALUES ('Los Angeles',1500,'Jan-05-1999');
INSERT INTO `Store_Information` VALUES ('San Diego',250,'Jan-07-1999');
INSERT INTO `Store_Information` VALUES ('San Francisco',300,'Jan-08-1999');
INSERT INTO `Store_Information` VALUES ('Boston',700,'Jan-08-1999');
CREATE TABLE IF NOT EXISTS `Geography` (
	`region_name`	TEXT,
	`store_name`	TEXT
);
INSERT INTO `Geography` VALUES ('East','Boston');
INSERT INTO `Geography` VALUES ('East','New York
');
INSERT INTO `Geography` VALUES ('West','Los Angeles');
INSERT INTO `Geography` VALUES ('West','San Diego');

