import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * PathsInLabirint
 */
public class PathsInLabirint {

//     5. Find All Paths in a Labyrinth
// You are given a labyrinth. Your goal is to find all paths from the start (cell 0, 0) to the exit, marked with &#39;e&#39;.
//  Empty cells are marked with a dash &#39;-&#39;
//  Walls are marked with a star &#39;*&#39;
// On the first line, you will receive the dimensions of the labyrinth. Next you will receive the actual labyrinth.
// The order of the paths does not matter.

    public static List<Character> path = new ArrayList<>();

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int row = Integer.parseInt(scanner.nextLine());
        int col = Integer.parseInt(scanner.nextLine());
        
        char[][] labyrinth = new char[row][col];

        for (int i = 0; i < row; i++) {
            labyrinth[i] = scanner.nextLine().toCharArray();
        }

        Paths(labyrinth, 0 ,0 , ' ');
        scanner.close();
    }

    private static void Paths(char[][] labyrinth, int row, int col, char direction) {
        if ((IfOutBound(labyrinth, row, col)) 
        || labyrinth[row][col] == 'V'
        || labyrinth[row][col] == '*') {
            
            return;
        }

        if (labyrinth[row][col] != 'e') {
        }
        
        // System.out.print(path);
        path.add(direction);

        if (labyrinth[row][col] == 'e') {
            Print();
            path.remove(path.size() - 1);
            return;
        }
        
        labyrinth[row][col] = 'V';
        
        Paths(labyrinth, row - 1 , col, 'U');
        Paths(labyrinth, row + 1, col, 'D');
        Paths(labyrinth, row, col - 1, 'L');
        Paths(labyrinth, row, col + 1, 'R');
        
        labyrinth[row][col] = '-';

        path.remove(path.size() - 1);
    }

    // private static boolean IfInBound(char[][] labyrinth, int row, int col) {
    //     return row < labyrinth.length && row >= 0 && col < labyrinth[row].length && col >= 0;
    // }

    private static boolean IfOutBound(char[][] labyrinth, int row, int col) {
        return row >= labyrinth.length || row < 0 || col >= labyrinth[row].length || col < 0;
    }

    private static void Print() {
        for (Character chr : path) {
            if (chr != ' ') {
                System.out.print(chr);
            }
        }
        System.out.println();
    }
}