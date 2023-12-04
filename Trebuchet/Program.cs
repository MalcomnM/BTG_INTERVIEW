// Read each line from the calibration document
string[] lines = File.ReadAllLines("calibration.txt"); // Replace with the actual file path


/**
 * Interview Question:
 * Elves have given you a calibration document to help restore the snow operations. However, the calibration 
 * document has been altered, and now each line contains various characters along with hidden calibration values.
 *
 * Your task is to process each line of the document to find the calibration values. Each line contains a calibration 
 * value that can be determined by combining the first digit and the last digit (in that order) found in the line to 
 * form a single two-digit number. For example, in the line "1abc2", the calibration value is 12.
 *
 * Implement the method CalculateTotalCalibrationValue to calculate the sum of these calibration values across all lines.
 * 
 * Note: If a line does not contain any digits, consider its calibration value as 0.
 * Example lines from the document:
 * "1abc2"    -> Calibration value is 12
 * "pqr3stu8" -> Calibration value is 38
 * "abcdef"   -> Calibration value is 0 (No digits in the line)
 */
static int CalculateTotalCalibrationValue(string[] lines)
{
    // Implement the logic here
    return 1;
}

// As part of the interview task, complete the implementation of the CalculateTotalCalibrationValue method.
int totalCalibrationValue = CalculateTotalCalibrationValue(lines);

Console.WriteLine($"Total Calibration Value: {totalCalibrationValue}");