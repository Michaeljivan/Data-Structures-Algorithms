public class BubbleSort {
	public static void main(String[]args){
		int number [] = {8, 3, 4, 1, 8};
					//	 0  1  2  3  4
		int temp;
		
		for (int i = 0; i < number.length; i++) {
			System.out.println(number[i]);
		}
		
		for(int i = 0; i < number.length - 1; i++) {
			
			if (number[i] > number[i + 1]) {
				// if 8 > 3
				temp = number[i + 1];
					//store 3 in temp
				
				number[i + 1] = number[i];
					// store 8 in position 3
				
				number[i] = temp;
				// set index to 3
			}
			
		}
		
		for (int i = 0; i < number.length; i++) {
			System.out.println(number[i]);
		}
		
	}
}
