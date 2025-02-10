package com.aicaptionlibrary;

public class CalculatorService2 implements ICalculatorService {
    // Remove the static block that loads the library
    
    private int internalAdd(int a, int b) {
        return a + b;  // Direct implementation
    }
    
    @Override
    public int addNumbers(int a, int b) {
        return internalAdd(a, b);
    }
    
    @Override
    public String getMessageText() {
        return "Hello from MAUI Library!";
    }
}