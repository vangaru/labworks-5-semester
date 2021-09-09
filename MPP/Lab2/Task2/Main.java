package com.company;

public class Main {

    public static void main(String[] args) {
        cat(args);
    }
    
    private static void cat (String[] args) {
        if (!argsCorrect(args))
            throw new IllegalArgumentException("File does not exist or is a directory");
        StringBuilder buffer = new StringBuilder();
        Scanner in = new Scanner(System.in);
        String s;
        for(int i = 0; i < args.length; i++) {

            if (i == args.length - 2 && Objects.equals(args[i], ""))
                writeBufferToFile(buffer, args[i + 1]);

            if (Objects.equals(args[i], "-")) {
                s = in.next();
                buffer.append(s);
                buffer.append("\n");
            }
            else
                buffer.append(readFileToBuffer(args[i]));
        }
        System.out.println(buffer);
    }
    
    private static boolean argsCorrect(String[] args) {
        for (String arg : args) {
            if (isSpecialSymbol(arg)) continue;
            if (!fileIsCorrect(arg)) return false;
        }
        return true;
    }

    private static boolean isSpecialSymbol(String arg) {
        return Objects.equals(arg, "-") || Objects.equals(arg, ">");
    }

    private static boolean fileIsCorrect(String fileName) {
        File file = new File(fileName);
        return file.exists() || !file.isDirectory();
    }

    private static void writeBufferToFile(StringBuilder buffer, String fileName) {
        try {
            tryToWriteBufferToFile(buffer, fileName);
        }
        catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
    }

    private static void tryToWriteBufferToFile(StringBuilder buffer, String fileName) throws IOException {
        File file = new File(fileName);
        if (!file.exists()) file.createNewFile();
        FileWriter fileWriter = new FileWriter(fileName, false);
        fileWriter.write(buffer.toString());
        fileWriter.flush();
    }

    private static StringBuilder readFileToBuffer(String fileName) {
        StringBuilder buffer;
        try {
             buffer = tryToReadFileToBuffer(fileName);
        }
        catch (IOException ex){
            System.out.println(ex.getMessage());
            return new StringBuilder();
        }
        return buffer;
    }

    private static StringBuilder tryToReadFileToBuffer(String fileName) throws IOException {
        StringBuilder buffer = new StringBuilder();
        FileReader fileReader = new FileReader(fileName);
        int c;
        while((c = fileReader.read()) != -1)
            buffer.append((char)c);

        return buffer;
    }
}
