use rest_with_asp_net_udemy;

CREATE TABLE `persons`(
`Id` int(10) UNSIGNED NULL DEFAULT NULL,
`FirstName` VARCHAR(50) NULL DEFAULT NULL,
`LastName` VARCHAR(50) NULL DEFAULT NULL,
`Address` VARCHAR(50) NULL DEFAULT NULL,
`Gender` VARCHAR(50) NULL DEFAULT NULL
)
ENGINE=InnoDB

ALTER TABLE persons CHANGE ID ID INT(10) AUTO_INCREMENT PRIMARY KEY;
;