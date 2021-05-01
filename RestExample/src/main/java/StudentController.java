
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/students")
public class StudentController
{
    @Autowired
    private IStudentService service;

    @GetMapping
    public List<Student> findAll()
    {
        return service.findAll();
    }

    @GetMapping(value = "/{id}")
    public Student findById(@PathVariable("id")int id)
    {
        return service.findById(id);
    }

    @PostMapping
    @ResponseStatus(HttpStatus.CREATED)
    public int create(@RequestBody Student resource)
    {
        return service.create(resource);
    }

    @PutMapping
    @ResponseStatus(HttpStatus.OK)
    public void update(@PathVariable("id")int id, @RequestBody Student resource)
    {
        service.update(resource);
    }

    @DeleteMapping(value = "/{id}")
    @ResponseStatus(HttpStatus.OK)
    public void delete(@PathVariable("id")int id) {
        service.deleteById(id);
    }
}
