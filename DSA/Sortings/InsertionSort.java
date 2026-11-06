import java.util.ArrayList;

public class InsertionSort {

	public static void main(String[] args) {
		ArrayList<Integer> my_array = new ArrayList<>();
		int[] initial = {25,83,26,12,72,81,2,6};
		
		for (int num : initial) {
			my_array.add(num);
		}
		
		int n = my_array.size();
		
		for (int i = 1; i < n; i++) {
			int insert_index = i;
			int current_value = my_array.remove(i);
			
			System.out.println("Removed: "+current_value);
			
			for (int j = i-1; j >=0; j--) {
				
				System.out.println("Compared: "+my_array.get(j)+" and "+current_value);
				
				if (my_array.get(j)>current_value) {
					insert_index = j;	
				}
						
			}
			my_array.add(insert_index,current_value);
			System.out.println("Inserted: "+current_value+" at position "+ insert_index);
		}
		
		System.out.print("Sorted array: ");
		for (int num : my_array) {
			System.out.print(num + " ");
		}
		
		
		
		
		
		

	}

}
