/* a) fetch worker names with salaries >= 50000 and <= 100000 */
SELECT FIRST_NAME 
FROM Worker
WHERE SALARY >= 50000 and SALARY <= 100000;

/* b) fetch no. of workers for each department in descending order */
SELECT DEPARTMENT, count(FIRST_NAME)
FROM Worker
GROUP BY DEPARTMENT
ORDER BY DEPARTMENT DESC;

/* c) fetch intersecting records of two tables */
SELECT w.FIRST_NAME, t.WORKER_TITLE
FROM Worker w, Title t
WHERE w.WORKER_ID = t.WORKER_REF_ID
    and w.WORKER_ID = 1;

/* d) determine the 5th highest salary without using TOP or limit method */
SELECT DISTINCT SALARY 
FROM Worker w1 
WHERE 5 = (
	SELECT COUNT(DISTINCT SALARY) 
	FROM Worker w2 
	WHERE w2.SALARY > w1.SALARY);
