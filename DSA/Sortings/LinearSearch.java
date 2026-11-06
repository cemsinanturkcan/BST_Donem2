
public class LinearSearch {

	public static int linearSearch(int[] arr, int targetVal) {
		System.out.println("Traverse the array from start to end");
		for (int i = 0; i < arr.length; i++) {
			System.out.println("Compare the target value to the values of the array. i= " + i);

			if (arr[i] == targetVal) {

				System.out.println("i: " + i + "; arr[" + i + "] = " + arr[i] + "; targetVal = " + targetVal);
				return i;
			}
		}
		return -1;
	}

	public static void main(String[] args) {
		int[] arr = { 3, 7, 2, 9, 5 };
		int targetVal = 9;
		int result = linearSearch(arr, targetVal);

		if (result != -1) {
			System.out.println("Value " + targetVal + " found at index " + result);

		} else {

			System.out.println("Value " + targetVal + " not found");

		}
	}

}
