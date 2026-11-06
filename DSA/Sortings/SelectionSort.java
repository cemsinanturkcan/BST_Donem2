
public class SelectionSort {

	public static void main(String[] args) {
		
		//İsteğine göre değiştir dizinin içini
		int[] dizi = {756,5,6,80,25};
		int diziboyutu = dizi.length;
		int enkucukIndex;
		int	enkucuk = dizi[0];
		
		for (int i = 0; i < diziboyutu-1; i++) {
			
			System.out.print("i = "+i+" / ");
			enkucukIndex = i;
			
			for (int j = i+1; j < diziboyutu; j++) {
				System.out.print("j= "+j+" / ");
				if (dizi[i]>dizi[enkucukIndex])
					enkucuk = dizi[i];
			}
			
			System.out.print("*Min value= "+dizi[enkucukIndex]+"*");
			int temp = dizi[enkucukIndex];
			dizi[enkucukIndex] = dizi[i];
			dizi[i] = temp;
			System.out.println(">");

		}
		
		System.out.print("Sorted array: ");
		for (int i : dizi) {
			System.out.print(i+" ");
		}
		

	}

}
