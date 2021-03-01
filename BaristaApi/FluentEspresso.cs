using System.Collections.Generic;

public class FluentEspresso {

    private int _water = 0;
    private int _milk = 0;
    private List<string> _beans = new List<string>();

    public FluentEspresso AddWater(int amount) {
        _water += amount;
        return this;
    }

    public FluentEspresso AddMilk(int amount) {
        _milk += amount;
        return this;
    }

    public FluentEspresso FoamMilk() {

        return this;
    }
}