package Clases;
import ClasesAbstractas.Animal;
import Interfaces.*;

public class Pato extends Animal implements Nadar, Volar {

    public Pato(String nombre) {
        super(nombre);
    }

    @Override
    public void nadar() {
        System.out.println(nombre + " está nadando.");
    }

    @Override
    public void volar() {
        System.out.println(nombre + " está volando.");
    }
}