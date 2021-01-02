package com.entity;

/**
 * @ClassName Person
 * @Author $童一
 * @Description $
 * @Param $
 * @return $
 * @Date $ $
 **/

public class Person {
    public int id;
    public String password;
    public  String image;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getImage() {
        return image;
    }

    public void setImage(String image) {
        this.image = image;
    }

    @Override
    public String toString() {
        return "Person{" +
                "id=" + id +
                ", password='" + password + '\'' +
                ", image='" + image + '\'' +
                '}';
    }
}
