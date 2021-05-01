import java.util.List;

public interface IStudentService
{
    List<Student> findAll();

    Student findById(int id);

    int create(Student student);

    void update(Student student);

    void deleteById(int id);
}
